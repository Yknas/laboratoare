using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using Web.Clients.Interfaces;
using Web.Models;

namespace Web.Clients;

public class ImapEmailClient : IImapEmailClient
{
    private readonly string _email;
    private readonly string _password;

    public ImapEmailClient(IOptions<EmailSettings> options)
    {
        _email = options.Value.Email;
        _password = options.Value.AppPassword;
    }

    public async Task<List<MimeMessage>> FetchEmailsAsync()
    {
        var emails = new List<MimeMessage>();
        
        using (var client = new ImapClient())
        {
            await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
            await client.AuthenticateAsync(_email, _password);

            var inbox = client.Inbox;
            await inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);

            var uids = await inbox.SearchAsync(SearchQuery.All);
            var latestUids = uids.TakeLast(30).ToList();

            foreach (var uid in latestUids)
            {
                var email = await inbox.GetMessageAsync(uid);
                emails.Add(email);
            }

            await client.DisconnectAsync(true);
        }

        return emails;
    }

    public async Task<MimeMessage?> GetEmailDetailsAsync(string id)
    {
        MimeMessage? email = null;

        using (var client = new ImapClient())
        {
            await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
            await client.AuthenticateAsync(_email, _password);

            var inbox = client.Inbox;
            await inbox.OpenAsync(MailKit.FolderAccess.ReadOnly);

            var uids = await inbox.SearchAsync(SearchQuery.HeaderContains("Message-ID", id));
            if (uids.Any())
            {
                email = await inbox.GetMessageAsync(uids.First());
            }

            await client.DisconnectAsync(true);
        }

        return email;
    }

    public async Task<bool> DownloadEmailAsync(string id)
    {
        var email = await GetEmailDetailsAsync(id);

        if (email == null)
            return false;

        var directoryPath = @"E:\Downloads\UTM\PR\Lab5";

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        var emlFilePath = Path.Combine(directoryPath, $"{email.Subject}_{DateTime.Now:yyyyMMddHHmmss}.eml");

        using (var emlStream = File.Create(emlFilePath))
        {
            await email.WriteToAsync(emlStream);
        }

        foreach (var attachment in email.Attachments)
        {
            if (attachment is MimePart part)
            {
                var filePath = Path.Combine(directoryPath, part.FileName);
                using (var stream = File.Create(filePath))
                {
                    await part.Content.DecodeToAsync(stream);
                }
            }
        }

        return true;
    }
}
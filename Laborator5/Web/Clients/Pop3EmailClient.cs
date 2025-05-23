using MailKit.Net.Pop3;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using Web.Clients.Interfaces;
using Web.Models;

namespace Web.Clients;

public class Pop3EmailClient : IPop3EmailClient
{
    private readonly string _email;
    private readonly string _password;

    public Pop3EmailClient(IOptions<EmailSettings> options)
    {
        _email = options.Value.Email;
        _password = options.Value.AppPassword;
    }

    public async Task<List<MimeMessage>> FetchEmailsAsync()
    {
        var emails = new List<MimeMessage>();

        using (var client = new Pop3Client())
        {
            await client.ConnectAsync("pop.gmail.com", 995, SecureSocketOptions.SslOnConnect);
            await client.AuthenticateAsync(_email, _password);

            int totalEmails = client.Count;
            var emailMessages = await client.GetMessagesAsync(totalEmails - 30, 30);
            emails.AddRange(emailMessages);

            await client.DisconnectAsync(true);
        }

        return emails;
    }
}
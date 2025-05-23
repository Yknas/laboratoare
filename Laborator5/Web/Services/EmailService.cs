using MimeKit;
using Web.Clients;
using Web.Clients.Interfaces;
using Web.Models;

namespace Web.Services;

public class EmailService : IEmailService
{
    private readonly IPop3EmailClient _pop3Client;
    private readonly IImapEmailClient _imapClient;
    private readonly ISmptEmailClient _smtpEmailClient;
    private readonly string _uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

    public EmailService(IPop3EmailClient pop3Client, IImapEmailClient imapClient, ISmptEmailClient smtpEmailClient)
    {
        _pop3Client = pop3Client;
        _imapClient = imapClient;
        _smtpEmailClient = smtpEmailClient;
    }

    public async Task<List<MimeMessage>> GetEmailsViaPop3()
    {
        return await _pop3Client.FetchEmailsAsync();
    }

    public async Task<List<MimeMessage>> GetEmailsViaImap()
    {
        return await _imapClient.FetchEmailsAsync();
    }

    public async Task<MimeMessage> GetEmailDetails(string id)
    {
        return await _imapClient.GetEmailDetailsAsync(id);
    }

    public async Task<bool> DownloadEmailWithAttachments(string id)
    {
        return await _imapClient.DownloadEmailAsync(id);
    }

    public async Task<bool> SendEmailWithAttachments(EmailModel email)
    {
        var result = await _smtpEmailClient.SendEmailAsync(email);
        
        return result;
    }
}
using MimeKit;
using Web.Models;

namespace Web.Services;

public interface IEmailService
{
    Task<List<MimeMessage>> GetEmailsViaPop3();
    Task<List<MimeMessage>> GetEmailsViaImap();
    Task<MimeMessage> GetEmailDetails(string id);
    Task<bool> DownloadEmailWithAttachments(string id);
    Task<bool> SendEmailWithAttachments(EmailModel email);
}
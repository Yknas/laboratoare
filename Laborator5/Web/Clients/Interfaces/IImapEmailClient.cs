using MimeKit;

namespace Web.Clients.Interfaces;

public interface IImapEmailClient
{
    public Task<List<MimeMessage>> FetchEmailsAsync();
    public Task<MimeMessage> GetEmailDetailsAsync(string id);
    public Task<bool> DownloadEmailAsync(string id);
}
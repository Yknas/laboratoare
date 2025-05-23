using MimeKit;

namespace Web.Clients.Interfaces;

public interface IPop3EmailClient
{
    public Task<List<MimeMessage>> FetchEmailsAsync();
}
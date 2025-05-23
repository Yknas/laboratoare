using System.Net.Mail;
using Web.Models;

namespace Web.Clients.Interfaces;

public interface ISmptEmailClient
{
    public Task<bool> SendEmailAsync(EmailModel email);
}
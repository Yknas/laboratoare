using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using Web.Clients.Interfaces;
using Web.Models;

namespace Web.Clients
{
    public class SmtpEmailClient : ISmptEmailClient
    {
        private readonly string _email;
        private readonly string _password;

        public SmtpEmailClient(IOptions<EmailSettings> options)
        {
            _email = options.Value.Email;
            _password = options.Value.AppPassword;
        }

        public async Task<bool> SendEmailAsync(EmailModel email)
        {
            using var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(_email, _password);
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;

            using var message = new MailMessage();
            message.From = new MailAddress(_email);
            message.Subject = email.Subject;
            message.Body = email.Body;
            message.IsBodyHtml = true;
            message.ReplyToList.Add(new MailAddress(_email));

            message.To.Add(email.To);

            if (email.Attachments.Count > 0)
            {
                foreach (var attachment in email.Attachments)
                {
                    var memoryStream = new MemoryStream();
                    await attachment.CopyToAsync(memoryStream);
        
                    memoryStream.Position = 0;

                    var mailAttachment = new Attachment(memoryStream, attachment.FileName);

                    message.Attachments.Add(mailAttachment);
                }
            }
            
            try
            {
                await smtpClient.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Email sending failed: {ex.Message}");
                return false;
            }
        }
    }
}
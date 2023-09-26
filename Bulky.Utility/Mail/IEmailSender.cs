namespace Bulky.Utility.Mail;
public interface IEmailSender
{
    Task<bool> SendEmailAsync(Email email);
}
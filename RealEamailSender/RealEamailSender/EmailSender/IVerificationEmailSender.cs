namespace RealEamailSender.EmailSender
{
    public interface IVerificationEmailSender
    {
        Task<bool> SendVerificationEmailAsync(string email,string verificationLink);
    }
}

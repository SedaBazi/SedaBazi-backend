namespace SedaBazi.Application.Services.Users.Commands.ForgotPassword
{
    public class ForgotPasswordRequest
    {
        public string Email { get; set; }

        public ForgotPasswordRequest(string email) => 
            Email = email;
    }
}

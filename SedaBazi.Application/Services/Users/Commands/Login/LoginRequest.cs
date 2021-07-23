namespace SedaBazi.Application.Services.Users.Commands.Login
{
    public class LoginRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsPersistent { get; set; }

        public LoginRequest(string email, string password, bool isPersistent)
        {
            Email = email;
            Password = password;
            IsPersistent = isPersistent;
        }
    }
}

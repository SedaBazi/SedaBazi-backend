namespace SedaBazi.Application.Services.Users.Commands.LoginUser
{
    public class RequestLoginUserDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}

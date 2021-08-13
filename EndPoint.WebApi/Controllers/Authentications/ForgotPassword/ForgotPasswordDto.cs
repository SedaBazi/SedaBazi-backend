using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Authentications.ForgotPassword
{
    public class ForgotPasswordDto
    {
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public bool SendByEmail { get; set; } = true;
    }
}

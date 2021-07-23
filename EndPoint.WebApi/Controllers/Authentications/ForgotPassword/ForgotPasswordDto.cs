using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Authentications.ForgotPassword
{
    public class ForgotPasswordDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

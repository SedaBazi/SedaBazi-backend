using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Authentications.Login
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}

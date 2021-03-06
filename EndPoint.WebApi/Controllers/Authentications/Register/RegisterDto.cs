using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Authentications.Register
{
    public class RegisterDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool IsPublisher { get; set; }
    }
}

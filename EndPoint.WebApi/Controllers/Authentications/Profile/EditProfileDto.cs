using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Authentications.Profile
{
    public class EditProfileDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}

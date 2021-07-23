using Microsoft.AspNetCore.Identity;

namespace SedaBazi.Domain.Entities.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}

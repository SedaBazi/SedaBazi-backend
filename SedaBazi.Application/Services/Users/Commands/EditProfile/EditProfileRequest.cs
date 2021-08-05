namespace SedaBazi.Application.Services.Users.Commands.EditProfile
{
    public class EditProfileRequest
    {
        public string Email { get; }

        public string FirstName { get; }

        public string LastName { get; }
        
        public EditProfileRequest(string firstName, string lastName, string email)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

namespace SedaBazi.Application.Services.Users.Queries.GetProfile
{
    public class GetProfileDto
    {
        public string Email { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public bool IsPublisher { get; }

        public bool IsPremium { get; }

        public GetProfileDto(string email, string firstName, string lastName, bool isPublisher, bool isPremium)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            IsPublisher = isPublisher;
            IsPremium = isPremium;
        }
    }
}

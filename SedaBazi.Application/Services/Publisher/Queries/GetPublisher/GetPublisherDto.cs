namespace SedaBazi.Application.Services.Publisher.Queries.GetPublisher
{
    public class GetPublisherDto
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public GetPublisherDto(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}

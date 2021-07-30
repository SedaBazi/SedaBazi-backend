namespace SedaBazi.Application.Services.Users.Queries.GetProfile
{
    public class GetProfileRequest
    {
        public string Email { get; }

        public GetProfileRequest(string email) =>
            Email = email;
    }
}

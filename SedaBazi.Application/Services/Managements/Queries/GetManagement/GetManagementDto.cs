namespace SedaBazi.Application.Services.Managements.Queries.GetManagement
{
    public class GetManagementDto
    {
        public string User { get; }

        public GetManagementDto(string user) =>
            User = user;
    }
}

namespace SedaBazi.Application.Services.Managements.Queries.GetManagement
{
    public class GetManagementDto
    {
        public long Id { get; set; }

        public string User { get; }

        public long AudioCollectionId { get; set; }

        public GetManagementDto(long id, string user, long audioCollectionId)
        {
            Id = id;
            User = user;
            AudioCollectionId = audioCollectionId;
        }
    }
}

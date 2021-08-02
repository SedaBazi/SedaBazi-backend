namespace SedaBazi.Application.Services.Managements.Queries.GetManagement
{
    public class GetManagementRequest
    {
        public long AudioCollectionId { get; }

        public GetManagementRequest(long audioCollectionId) =>
            AudioCollectionId = audioCollectionId;
    }
}

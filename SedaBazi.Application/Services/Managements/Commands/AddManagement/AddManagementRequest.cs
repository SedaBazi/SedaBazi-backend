namespace SedaBazi.Application.Services.Managements.Commands.AddManagement
{
    public class AddManagementRequest
    {
        public string User { get; }

        public long AudioCollectionId { get; }

        public string Owner { get; }

        public AddManagementRequest(string user, long audioCollectionId, string owner)
        {
            User = user;
            AudioCollectionId = audioCollectionId;
            Owner = owner;
        }
    }
}

namespace SedaBazi.Application.Services.Managements.Commands.DeleteManagement
{
    public class DeleteManagementRequest
    {
        public long Id { get; }

        public string Owner { get; }

        public DeleteManagementRequest(long id, string owner)
        {
            Id = id;
            Owner = owner;
        }
    }
}

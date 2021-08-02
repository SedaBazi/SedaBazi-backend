using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Management
{
    public class AddManagementDto
    {
        [Required]
        public string User { get; set; }

        [Required]
        public long AudioCollectionId { get; set; }
    }
}

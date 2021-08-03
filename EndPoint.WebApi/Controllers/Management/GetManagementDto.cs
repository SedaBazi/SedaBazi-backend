using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Management
{
    public class GetManagementDto
    {
        [Required]
        public long AudioCollectionId { get; set; }
    }
}

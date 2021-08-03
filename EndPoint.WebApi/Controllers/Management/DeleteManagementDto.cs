using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Management
{
    public class DeleteManagementDto
    {
        [Required]
        public long Id { get; set; }
    }
}

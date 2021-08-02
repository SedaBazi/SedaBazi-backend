using SedaBazi.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;

namespace SedaBazi.Domain.Entities.Managements
{
    public class Management : BaseEntity
    {
        [Required]
        public string User { get; set; }

        [Required]
        public long AudioCollectionId { get; set; }
    }
}

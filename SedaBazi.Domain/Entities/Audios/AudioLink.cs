using SedaBazi.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;

namespace SedaBazi.Domain.Entities.Audios
{
    public class AudioLink : BaseEntity
    {
        [Required]
        public string User { get; set; }

        [Required]
        public long AudioId { get; set; }

        [Required]
        public long AudioCollectionId { get; set; }
    }
}

using SedaBazi.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;

namespace SedaBazi.Domain.Entities.Audios
{
    public class AudioCollection : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Owner { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public string Type { get; set; }
    }
}

using SedaBazi.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;

namespace SedaBazi.Domain.Entities.Audios
{
    public class Audio : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Owner { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public bool IsPremium { get; set; } = false;

        public string FileUrl128 { get; set; }

        public string FileUrl320 { get; set; }
    }
}

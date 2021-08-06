using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Audio.Audio
{
    public class EditAudioDto
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public bool IsPremium { get; set; } = false;

        public string FileUrl128 { get; set; }

        public string FileUrl320 { get; set; }
    }
}

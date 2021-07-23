using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Audio.AudioCollection
{
    public class AudioCollectionDto
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public string Type { get; set; }
    }
}

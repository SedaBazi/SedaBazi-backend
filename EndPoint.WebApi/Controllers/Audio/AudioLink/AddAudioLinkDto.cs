using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Audio.AudioLink
{
    public class AddAudioLinkDto
    {
        [Required]
        public long AudioId { get; set; }

        [Required]
        public long AudioCollectionId { get; set; }
    }
}

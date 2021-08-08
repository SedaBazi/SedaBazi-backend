using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Audio.AudioLink
{
    public class DeleteAudioLinkDto
    {
        [Required]
        public long Id { get; set; }
    }
}

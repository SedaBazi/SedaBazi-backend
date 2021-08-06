using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Audio.Audio
{
    public class DeleteAudioDto
    {
        [Required]
        public long Id { get; set; }
    }
}

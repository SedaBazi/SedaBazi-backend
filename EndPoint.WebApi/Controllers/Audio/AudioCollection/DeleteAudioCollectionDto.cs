using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebApi.Controllers.Audio.AudioCollection
{
    public class DeleteAudioCollectionDto
    {
        [Required]
        public long Id { get; set; }
    }
}

namespace SedaBazi.Application.Services.Audios.Commands.EditAudioCollection
{
    public class EditAudioCollectionRequest
    {
        public long Id { get; set; }

        public string Owner { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }
    }
}

namespace SedaBazi.Application.Services.Audios.Commands.AddAudioCollection
{
    public class AddAudioCollectionRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Owner { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }
    }
}

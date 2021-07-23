namespace SedaBazi.Application.Services.Audios.Commands.AddAudioCollection
{
    public class AddAudioCollectionRequest
    {
        public string Name { get; }

        public string Description { get; }

        public string Owner { get; }

        public string ImageUrl { get; }

        public string Type { get; }

        public AddAudioCollectionRequest(string name, string description,
            string owner, string imageUrl, string type)
        {
            Name = name;
            Description = description;
            Owner = owner;
            ImageUrl = imageUrl;
            Type = type;
        }
    }
}

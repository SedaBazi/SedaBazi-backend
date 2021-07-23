namespace SedaBazi.Application.Services.Audios.Commands.EditAudioCollection
{
    public class EditAudioCollectionRequest
    {
        public long Id { get; }

        public string Owner { get; }

        public string Name { get; }

        public string Description { get; }

        public string ImageUrl { get; }

        public string Type { get; }

        public EditAudioCollectionRequest(long id, string owner, 
            string name, string description, string imageUrl, string type)
        {
            Id = id;
            Owner = owner;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Type = type;
        }
    }
}

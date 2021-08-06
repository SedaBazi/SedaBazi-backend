namespace SedaBazi.Application.Services.Audios.Commands.EditAudio
{
    public class EditAudioRequest
    {
        public long Id { get; }

        public string Owner { get; }

        public string Name { get; }

        public string Description { get; }

        public string ImageUrl { get; }

        public bool IsPremium { get; } = false;

        public string FileUrl128 { get; }

        public string FileUrl320 { get; }

        public EditAudioRequest(long id, string owner, string name, string description,
            string imageUrl, bool isPremium, string fileUrl128, string fileUrl320)
        {
            Id = id;
            Owner = owner;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            IsPremium = isPremium;
            FileUrl128 = fileUrl128;
            FileUrl320 = fileUrl320;
        }
    }
}

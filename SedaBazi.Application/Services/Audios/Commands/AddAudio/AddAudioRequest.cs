namespace SedaBazi.Application.Services.Audios.Commands.AddAudio
{
    public class AddAudioRequest
    {
        public string Name { get; }

        public string Description { get; }

        public string Owner { get; }

        public string ImageUrl { get; }

        public bool IsPremium { get; } = false;

        public string FileUrl128 { get; }

        public string FileUrl320 { get; }

        public AddAudioRequest(string name, string description, string owner,
            string imageUrl, bool isPremium, string fileUrl128, string fileUrl320)
        {
            Name = name;
            Description = description;
            Owner = owner;
            ImageUrl = imageUrl;
            IsPremium = isPremium;
            FileUrl128 = fileUrl128;
            FileUrl320 = fileUrl320;
        }
    }
}

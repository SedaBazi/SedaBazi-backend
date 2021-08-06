namespace SedaBazi.Application.Services.Audios.Queries.GetAudio
{
    public class GetAudioRequest
    {
        public int Page { get; }

        public int Size { get; }

        public GetAudioRequest(int page, int size)
        {
            Page = page;
            Size = size;
        }
    }
}

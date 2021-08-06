namespace SedaBazi.Application.Services.Audios.Queries.GetAudio
{
    public class GetAudioRequest
    {
        public int Page { get; }

        public int Size { get; }

        public string SearchValue { get; }

        public GetAudioRequest(int page, int size, string searchValue)
        {
            Page = page;
            Size = size;
            SearchValue = searchValue;
        }
    }
}

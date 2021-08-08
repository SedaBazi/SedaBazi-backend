namespace SedaBazi.Application.Services.Audios.Queries.GetAudio
{
    public class GetAudioRequest
    {
        public int Page { get; }

        public int Size { get; }

        public string SearchValue { get; }

        public long? AudioCollectionId { get; }

        public GetAudioRequest(int page, int size, string searchValue, long? audioCollectionId)
        {
            Page = page;
            Size = size;
            SearchValue = searchValue;
            AudioCollectionId = audioCollectionId;
        }
    }
}

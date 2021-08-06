namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class GetAudioCollectionRequest
    {
        public int Page { get; }

        public int Size { get; }

        public string SearchValue { get; }

        public GetAudioCollectionRequest(int page, int size, string searchValue)
        {
            Page = page;
            Size = size;
            SearchValue = searchValue;
        }
    }
}

namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class GetAudioCollectionRequest
    {
        public int Page { get; }

        public int Size { get; }

        public GetAudioCollectionRequest(int page, int size)
        {
            Page = page;
            Size = size;
        }
    }
}

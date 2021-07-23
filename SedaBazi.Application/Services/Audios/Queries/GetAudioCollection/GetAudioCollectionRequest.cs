namespace SedaBazi.Application.Services.Audios.Queries.GetAudioCollection
{
    public class GetAudioCollectionRequest
    {
        public int Page { get; set; }

        public int Size { get; set; }

        public GetAudioCollectionRequest(int page, int size)
        {
            Page = page;
            Size = size;
        }
    }
}

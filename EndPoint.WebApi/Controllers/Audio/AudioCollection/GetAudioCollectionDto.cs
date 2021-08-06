namespace EndPoint.WebApi.Controllers.Audio.AudioCollection
{
    public class GetAudioCollectionDto
    {
        public int Page { get; set; }

        public int Size { get; set; }

        public string SearchValue { get; set; }
    }
}

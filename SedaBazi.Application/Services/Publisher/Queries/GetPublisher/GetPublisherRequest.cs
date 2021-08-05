namespace SedaBazi.Application.Services.Publisher.Queries.GetPublisher
{
    public class GetPublisherRequest
    {
        public string SearchValue { get; }

        public GetPublisherRequest(string searchValue) =>
            SearchValue = searchValue;
    }
}

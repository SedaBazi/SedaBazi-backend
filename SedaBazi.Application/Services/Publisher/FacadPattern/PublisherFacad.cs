using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Publisher.Queries.GetPublisher;

namespace SedaBazi.Application.Services.Publisher.FacadPattern
{
    public class PublisherFacad : IPublisherFacad
    {
        private readonly IDataBaseContext dataBaseContext;

        private IGetPublisherService getPublisherService;

        public PublisherFacad(IDataBaseContext dataBaseContext) =>
            this.dataBaseContext = dataBaseContext;

        public IGetPublisherService GetPublisherService
        {
            get
            {
                return getPublisherService ??= new GetPublisherService(dataBaseContext);
            }
        }
    }
}

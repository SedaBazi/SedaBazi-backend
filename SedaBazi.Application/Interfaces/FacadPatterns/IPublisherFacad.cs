using SedaBazi.Application.Services.Publisher.Queries.GetPublisher;

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IPublisherFacad
    {
        IGetPublisherService GetPublisherService { get; }
    }
}

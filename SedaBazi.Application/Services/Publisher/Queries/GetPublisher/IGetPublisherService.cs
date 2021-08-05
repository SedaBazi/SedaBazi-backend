using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Publisher.Queries.GetPublisher
{
    public interface IGetPublisherService
    {
        ResultDto<ResultGetPublisherDto> Execute(GetPublisherRequest request);
    }
}

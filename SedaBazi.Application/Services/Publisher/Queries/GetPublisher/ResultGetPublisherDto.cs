using System.Collections.Generic;

namespace SedaBazi.Application.Services.Publisher.Queries.GetPublisher
{
    public class ResultGetPublisherDto
    {
        public List<GetPublisherDto> GetPublisherDtos { get; }

        public ResultGetPublisherDto(List<GetPublisherDto> getPublisherDtos) =>
            GetPublisherDtos = getPublisherDtos;
    }
}

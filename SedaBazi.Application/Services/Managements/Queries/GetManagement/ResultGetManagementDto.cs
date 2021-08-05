using System.Collections.Generic;

namespace SedaBazi.Application.Services.Managements.Queries.GetManagement
{
    public class ResultGetManagementDto
    {
        public List<GetManagementDto> GetManagementDtos { get; }

        public ResultGetManagementDto(List<GetManagementDto> getManagementDtos) =>
            GetManagementDtos = getManagementDtos;
    }
}

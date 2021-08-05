using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Users.Queries.GetProfile
{
    public interface IGetProfileService
    {
        public ResultDto<GetProfileDto> Execute(GetProfileRequest request);
    }
}

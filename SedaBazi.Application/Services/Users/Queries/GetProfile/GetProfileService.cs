using Microsoft.AspNetCore.Identity;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;

namespace SedaBazi.Application.Services.Users.Queries.GetProfile
{
    public class GetProfileService : IGetProfileService
    {
        private readonly UserManager<User> userManager;

        public GetProfileService(UserManager<User> userManager) =>
            this.userManager = userManager;

        public ResultDto<GetProfileDto> Execute(GetProfileRequest request)
        {
            var user = userManager.FindByNameAsync(request.Email).Result;

            var result = new GetProfileDto(user.Email, user.FirstName, user.LastName, user.IsPublisher, user.IsPremium);

            return new ResultDto<GetProfileDto>(true, "Profile returned successfully.", result);
        }
    }
}

using Microsoft.AspNetCore.Identity;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;
using System.Linq;

namespace SedaBazi.Application.Services.Users.Commands.EditProfile
{
    public class EditProfileService : IEditProfileService
    {
        private readonly UserManager<User> userManager;

        public EditProfileService(UserManager<User> userManager) =>
            this.userManager = userManager;

        public ResultDto Execute(EditProfileRequest request)
        {
            var user = userManager.FindByNameAsync(request.Email).Result;

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;

            var result = userManager.UpdateAsync(user).Result;

            if (result.Succeeded)
            {
                return new ResultDto(true, "Profile edited successfully.");
            }

            var errorMessage = string.Join("\n", result.Errors.Select(x => x.Description));
            return new ResultDto(false, errorMessage);
        }
    }
}

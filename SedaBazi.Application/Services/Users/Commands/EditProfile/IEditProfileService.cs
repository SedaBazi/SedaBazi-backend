using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Users.Commands.EditProfile
{
    public interface IEditProfileService
    {
        ResultDto Execute(EditProfileRequest request);
    }
}

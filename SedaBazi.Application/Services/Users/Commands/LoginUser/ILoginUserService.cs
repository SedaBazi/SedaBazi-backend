using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Users.Commands.LoginUser
{
    public interface ILoginUserService
    {
        ResultDto Execute(RequestLoginUserDto request);
    }
}

using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Users.Commands.RegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto Execute(RequestRegisterUserDto request);
    }
}

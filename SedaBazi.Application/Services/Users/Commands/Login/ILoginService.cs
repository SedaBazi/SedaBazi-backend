using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Users.Commands.Login
{
    public interface ILoginService
    {
        ResultDto Execute(LoginRequest request);
    }
}

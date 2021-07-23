using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Users.Commands.Register
{
    public interface IRegisterService
    {
        ResultDto Execute(RegisterRequest request);
    }
}

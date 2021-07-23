using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Users.Commands.ForgotPassword
{
    public interface IForgotPasswordService
    {
        ResultDto Execute(ForgotPasswordRequest request);
    }
}

using SedaBazi.Application.Services.Users.Commands.EditProfile;
using SedaBazi.Application.Services.Users.Commands.ForgotPassword;
using SedaBazi.Application.Services.Users.Commands.Login;
using SedaBazi.Application.Services.Users.Commands.Logout;
using SedaBazi.Application.Services.Users.Commands.Register;
using SedaBazi.Application.Services.Users.Queries.GetProfile;

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IUserFacad
    {
        IRegisterService RegisterService { get; }
        ILoginService LoginService { get; }
        ILogoutService LogoutService { get; }
        IForgotPasswordService ForgotPasswordService { get; }
        IEditProfileService EditProfileService { get; }
        IGetProfileService GetProfileService { get; }
    }
}

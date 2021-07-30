using Microsoft.AspNetCore.Identity;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Email;
using SedaBazi.Application.Services.Users.Commands.EditProfile;
using SedaBazi.Application.Services.Users.Commands.ForgotPassword;
using SedaBazi.Application.Services.Users.Commands.Login;
using SedaBazi.Application.Services.Users.Commands.Logout;
using SedaBazi.Application.Services.Users.Commands.Register;
using SedaBazi.Application.Services.Users.Queries.GetProfile;
using SedaBazi.Domain.Entities.Users;

namespace SedaBazi.Application.Services.Users.FacadPattern
{
    public class UserFacad : IUserFacad
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IEmailService emailService;

        private IRegisterService registerService;
        private ILoginService loginService;
        private ILogoutService logoutService;
        private IForgotPasswordService forgotPasswordService;
        private IEditProfileService editProfileService;
        private IGetProfileService getProfileService;

        public UserFacad(UserManager<User> userManager, SignInManager<User> signInManager, IEmailService emailService) 
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailService = emailService;
        }

        public IRegisterService RegisterService
        {
            get
            {
                return registerService ??= new RegisterService(userManager, signInManager);
            }
        }

        public ILoginService LoginService
        {
            get
            {
                return loginService ??= new LoginService(userManager, signInManager);
            }
        }

        public ILogoutService LogoutService
        {
            get
            {
                return logoutService ??= new LogoutService(signInManager);
            }
        }

        public IForgotPasswordService ForgotPasswordService
        {
            get
            {
                return forgotPasswordService ??= new ForgotPasswordService(userManager, emailService);
            }
        }

        public IEditProfileService EditProfileService
        {
            get
            {
                return editProfileService ??= new EditProfileService(userManager);
            }
        }

        public IGetProfileService GetProfileService
        {
            get
            {
                return getProfileService ??= new GetProfileService(userManager);
            }
        }
    }
}

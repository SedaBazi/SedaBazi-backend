using Microsoft.AspNetCore.Identity;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;

namespace SedaBazi.Application.Services.Users.Commands.Login
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager;

        public LoginService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public ResultDto Execute(LoginRequest request)
        {
            var user = userManager.FindByNameAsync(request.Email).Result;

            if (user == null)
            {
                return new ResultDto(false, "Email doesn't exist.");
            }

            signInManager.SignOutAsync();

            var result = signInManager.PasswordSignInAsync(user, request.Password, request.IsPersistent, true).Result;

            if (result.Succeeded)
            {
                return new ResultDto(true, "Login Successful.");
            }

            return new ResultDto(false, "Email and password don't match.");
        }
    }
}

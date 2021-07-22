using Microsoft.AspNetCore.Identity;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;

namespace SedaBazi.Application.Services.Users.Commands.LoginUser
{
    public class LoginUserService : ILoginUserService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public LoginUserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public ResultDto Execute(RequestLoginUserDto request)
        {
            var user = userManager.FindByNameAsync(request.Email).Result;

            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Email doesn't exist."
                };
            }

            signInManager.SignOutAsync();
            
            var result = signInManager.PasswordSignInAsync(user, request.Password, request.IsPersistent, true).Result;

            if (result.Succeeded)
            {
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "Login Successful."
                };
            }

            return new ResultDto
            {
                IsSuccess = false,
                Message = "Email and password don't match."
            };
        }
    }
}

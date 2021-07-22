using Microsoft.AspNetCore.Identity;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;
using System.Linq;

namespace SedaBazi.Application.Services.Users.Commands.RegisterUser
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public RegisterUserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public ResultDto Execute(RequestRegisterUserDto request)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.Email
            };
            
            var result = userManager.CreateAsync(user, request.Password).Result;

            if (result.Succeeded)
            {
                signInManager.SignOutAsync();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "Registration completed successfully.",
                };
            }

            return new ResultDto
            {
                IsSuccess = false,
                Message = string.Join("\n", result.Errors.Select(x => x.Description)),
            };
        }
    }
}

using Microsoft.AspNetCore.Identity;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;

namespace SedaBazi.Application.Services.Users.Commands.Logout
{
    public class LogoutService : ILogoutService
    {
        private readonly SignInManager<User> signInManager;

        public LogoutService(SignInManager<User> signInManager) =>
            this.signInManager = signInManager;

        public ResultDto Execute()
        {
            signInManager.SignOutAsync();
            return new ResultDto(true, "Logout Successful.");
        }
    }
}

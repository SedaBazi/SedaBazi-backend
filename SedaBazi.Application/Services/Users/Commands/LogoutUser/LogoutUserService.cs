using Microsoft.AspNetCore.Identity;
using SedaBazi.Domain.Entities.Users;

namespace SedaBazi.Application.Services.Users.Commands.LogoutUser
{
    public class LogoutUserService : ILogoutUserService
    {
        private readonly SignInManager<User> signInManager;

        public LogoutUserService(SignInManager<User> signInManager) =>
            this.signInManager = signInManager;

        public void Execute() =>
            signInManager.SignOutAsync();
    }
}

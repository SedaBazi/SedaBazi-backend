using Microsoft.AspNetCore.Identity;
using PasswordGenerator;
using SedaBazi.Application.Services.Email;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;
using System.Linq;

namespace SedaBazi.Application.Services.Users.Commands.ForgotPassword
{
    public class ForgotPasswordService : IForgotPasswordService
    {
        private readonly UserManager<User> userManager;
        private readonly IEmailService emailService;

        public ForgotPasswordService(UserManager<User> userManager, IEmailService emailService)
        {
            this.userManager = userManager;
            this.emailService = emailService;
        }

        public ResultDto Execute(RequestForgotPasswordDto request)
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

            var newPassword = new Password(8).Next();

            var title = "Forgot Password Email";
            var body = $"Your new password: {newPassword}";

            var token = userManager.GeneratePasswordResetTokenAsync(user).Result;
            emailService.Execute(request.Email, title, body);
            var result = userManager.ResetPasswordAsync(user, token, newPassword).Result;

            if (result.Succeeded)
            {
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "Password Reset Successfully."
                };
            }

            return new ResultDto
            {
                IsSuccess = false,
                Message = string.Join("\n", result.Errors.Select(x => x.Description))
            };
        }
    }
}

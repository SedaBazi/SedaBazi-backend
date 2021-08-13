using Microsoft.AspNetCore.Identity;
using PasswordGenerator;
using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Services.Email;
using SedaBazi.Application.Services.Sms;
using SedaBazi.Common.Dto;
using SedaBazi.Domain.Entities.Users;
using System.Linq;

namespace SedaBazi.Application.Services.Users.Commands.ForgotPassword
{
    public class ForgotPasswordService : IForgotPasswordService
    {
        private readonly UserManager<User> userManager;
        private readonly IEmailService emailService;
        private readonly ISmsService smsService;
        private readonly IDataBaseContext dataBaseContext;

        public ForgotPasswordService(UserManager<User> userManager, IEmailService emailService,
            ISmsService smsService, IDataBaseContext dataBaseContext)
        {
            this.userManager = userManager;
            this.emailService = emailService;
            this.smsService = smsService;
            this.dataBaseContext = dataBaseContext;
        }

        public ResultDto Execute(ForgotPasswordRequest request)
        {
            if (request.SendByEmail)
            {
                return ExecuteByEmail(request.Email);
            }

            return ExecuteByPhone(request.PhoneNumber);
        }

        private ResultDto ExecuteByEmail(string email)
        {
            var user = userManager.FindByNameAsync(email).Result;

            if (user == null)
            {
                return new ResultDto(false, "Email doesn't exist.");
            }

            var newPassword = new Password(8).Next();

            var title = "Forgot Password Email";
            var body = $"Your new password: {newPassword}";

            emailService.Execute(email, title, body);

            return ChangePassword(user, newPassword);
        }

        private ResultDto ExecuteByPhone(string phoneNumber)
        {
            var user = dataBaseContext.Users.FirstOrDefault(x => x.PhoneNumber == phoneNumber);

            if (user == null)
            {
                return new ResultDto(false, "Phone doesn't exist.");
            }

            user = userManager.FindByNameAsync(user.UserName).Result;

            var newPassword = new Password(8).Next();

            var message = $"Your new password: {newPassword}";

            smsService.Execute(phoneNumber, message);

            return ChangePassword(user, newPassword);
        }

        private ResultDto ChangePassword(User user, string newPassword)
        {
            var token = userManager.GeneratePasswordResetTokenAsync(user).Result;
            var result = userManager.ResetPasswordAsync(user, token, newPassword).Result;

            if (result.Succeeded)
            {
                return new ResultDto(true, "Password Reset Successfully.");
            }

            var errorMessage = string.Join("\n", result.Errors.Select(x => x.Description));
            return new ResultDto(false, errorMessage);
        }
    }
}

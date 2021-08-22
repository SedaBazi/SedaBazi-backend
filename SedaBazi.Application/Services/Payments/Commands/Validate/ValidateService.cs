using SedaBazi.Common.Dto;
using Dto.Payment;
using SedaBazi.Application.Interfaces.Contexts;
using System.Linq;
using ZarinPal.Class;
using Microsoft.Extensions.Configuration;

namespace SedaBazi.Application.Services.Payments.Commands.Validate
{
    public class ValidateService : IValidateService
    {
        private readonly Payment payment;
        private readonly IDataBaseContext dataBaseContext;
        private readonly IConfiguration configuration;

        public ValidateService(IDataBaseContext dataBaseContext, IConfiguration configuration)
        {
            payment = new Expose().CreatePayment();
            this.dataBaseContext = dataBaseContext;
            this.configuration = configuration;
        }

        public ResultDto Execute(ValidateRequest request)
        {
            var user = dataBaseContext.Users.First(x => x.Id == request.Guid.ToString());

            if (user.UserName != request.Username)
            {
                return new ResultDto(false, "User access is not allowed.");
            }

            var status = GetStatus(request);

            if (status == 100)
            {
                user.IsPremium = true;
                dataBaseContext.SaveChanges();
                return new ResultDto(true, "Payment successful.");
            }

            return new ResultDto(false, "Payment failed.");
        }

        private int GetStatus(ValidateRequest request)
        {
            var dtoVerification = new DtoVerification
            {
                Amount = int.Parse(configuration["Payment:Amount"]),
                MerchantId = configuration["Payment:MerchantId"],
                Authority = request.Authority
            };

            return payment.Verification(dtoVerification, Payment.Mode.sandbox).Result.Status;
        }
    }
}

using Microsoft.Extensions.Configuration;
using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Payments.Commands.Validate;

namespace SedaBazi.Application.Services.Payments.FacadPattern
{
    public class PaymentFacad : IPaymentFacad
    {
        private readonly IDataBaseContext dataBaseContext;

        private readonly IConfiguration configuration;

        private IValidateService validateService;

        public PaymentFacad(IDataBaseContext dataBaseContext, IConfiguration configuration)
        {
            this.dataBaseContext = dataBaseContext;
            this.configuration = configuration;
        }

        public IValidateService ValidateService
        {
            get
            {
                return validateService ??= new ValidateService(dataBaseContext, configuration);
            }
        }
    }
}

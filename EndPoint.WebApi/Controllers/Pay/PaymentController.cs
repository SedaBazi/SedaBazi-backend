using Dto.Payment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SedaBazi.Application.Interfaces.Contexts;
using System.Linq;
using System.Threading.Tasks;
using ZarinPal.Class;

namespace EndPoint.WebApi.Controllers.Pay
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly Payment payment;
        private readonly IDataBaseContext dataBaseContext;
        private readonly IConfiguration configuration;

        public PaymentController(IDataBaseContext dataBaseContext, IConfiguration configuration)
        {
            payment = new Expose().CreatePayment();
            this.dataBaseContext = dataBaseContext;
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var username = User.Identity.Name;

            if (username == null)
            {
                return Content("No user available.");
            }

            var user = dataBaseContext.Users.First(x => x.UserName == username);

            var userId = user.Id;
            var isPremium = user.IsPremium;

            if (isPremium)
            {
                return Content("User is premium.");
            }

            var dtoRequest = new DtoRequest()
            {
                CallbackUrl = string.Format(configuration["Payment:CallbackUrl"], userId),
                Description = configuration["Payment:Description"],
                Amount = int.Parse(configuration["Payment:Amount"]),
                MerchantId = configuration["Payment:MerchantId"]
            };

            var result = await payment.Request(dtoRequest, Payment.Mode.sandbox);

            var url = string.Format(configuration["Payment:sandboxUrl"], result.Authority);

            return Redirect(url);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Payments.Commands.Validate;
using SedaBazi.Common.Dto;
using System;

namespace EndPoint.WebApi.Controllers.Pay
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        private readonly IPaymentFacad paymentFacad;

        public ValidationController(IPaymentFacad paymentFacad) =>
            this.paymentFacad = paymentFacad;

        public ActionResult<ResultDto> Verify(Guid guid, string authority)
        {
            var username = User.Identity.Name;

            if (username == null)
            {
                return Content("No user available.");
            }

            var request = new ValidateRequest(guid, authority, username);

            return paymentFacad.ValidateService.Execute(request);
        }
    }
}

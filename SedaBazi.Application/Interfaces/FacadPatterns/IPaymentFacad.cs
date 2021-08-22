using SedaBazi.Application.Services.Payments.Commands.Validate;

namespace SedaBazi.Application.Interfaces.FacadPatterns
{
    public interface IPaymentFacad
    {
        IValidateService ValidateService { get; }
    }
}

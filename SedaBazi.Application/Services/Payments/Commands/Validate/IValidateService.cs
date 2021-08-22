using SedaBazi.Common.Dto;

namespace SedaBazi.Application.Services.Payments.Commands.Validate
{
    public interface IValidateService
    {
        ResultDto Execute(ValidateRequest request);
    }
}

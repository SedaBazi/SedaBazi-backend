using System.Threading.Tasks;

namespace SedaBazi.Application.Services.Sms
{
    public interface ISmsService
    {
        Task Execute(string phoneNumber, string message);
    }
}

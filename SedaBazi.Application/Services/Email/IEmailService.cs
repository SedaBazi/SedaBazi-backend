using System.Threading.Tasks;

namespace SedaBazi.Application.Services.Email
{
    public interface IEmailService
    {
        Task Execute(string email, string subject, string body);
    }
}

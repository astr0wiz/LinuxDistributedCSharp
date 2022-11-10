using System.Threading.Tasks;

namespace JJ.MsSub.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}

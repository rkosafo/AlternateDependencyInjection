using System;
using System.Threading.Tasks;

namespace Library1.Interfaces
{
    public interface IEmailService
    {
        Task<(string id, Exception error)> send(IEmailMessage message);
    }
}
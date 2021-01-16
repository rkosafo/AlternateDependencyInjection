using System;
using System.Threading.Tasks;

namespace Library1.Interfaces
{
    public interface ISmsService
    {
        Task<(string id, Exception error)> send(ISmsMessage message);
    }
}
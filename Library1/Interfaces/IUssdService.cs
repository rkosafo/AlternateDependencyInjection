using System;
using System.Threading.Tasks;

namespace Library1.Interfaces
{
    public interface IUssdService
    {
        Task<(string id, Exception error)> send(IUssdMessage message);
    }
}
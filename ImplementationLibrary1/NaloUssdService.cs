using Library1.Interfaces;
using System;
using System.Threading.Tasks;

namespace ImplementationLibrary1
{
    public class NaloUssdService : IUssdService
    {
        private static long _lastId = 0;

        private static string getNextMessageId() => $"nalo ussd service-{++_lastId}";
        public async Task<(string id, Exception error)> send(IUssdMessage message)
        {
            return (getNextMessageId(), default);
        }
    }
}

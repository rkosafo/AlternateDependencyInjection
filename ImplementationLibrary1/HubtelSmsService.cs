using Library1.Interfaces;
using System;
using System.Threading.Tasks;

namespace ImplementationLibrary1
{
    public class HubtelSmsService : ISmsService
    {
        private static long _lastId = 0;

        private static string getNextMessageId() => $"hubtel-{++_lastId}";
        public async Task<(string id, Exception error)> send(ISmsMessage message)
        {
            return (getNextMessageId(), default);
        }
    }
}

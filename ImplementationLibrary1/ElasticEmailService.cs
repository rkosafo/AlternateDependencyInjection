using Library1.Interfaces;
using System;
using System.Threading.Tasks;

namespace ImplementationLibrary1
{
    public class ElasticEmailService : IEmailService
    {
        private static long _lastId = 0;

        private static string getNextMessageId() => $"elatic email-{++_lastId}";
        public async Task<(string id, Exception error)> send(IEmailMessage message)
        {
            return (getNextMessageId(), default);
        }
    }
}

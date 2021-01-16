using Library1.Interfaces;
using System;
using System.Threading.Tasks;

namespace Library1
{
    public static class EmailService
    {
        private static IEmailService _impl = default;

        public static async Task<(string id, Exception error)> send(IEmailMessage message)
        {
            if (_impl != null) return await _impl.send(message);
            return (default, new NotImplementedException());
        }

        public static void setImplementation(IEmailService implementation)
        {
            _impl = implementation;
        }

        public static void setImplementation<T>() where T: IEmailService, new()
        {
            setImplementation(new T());
        }
    }
}
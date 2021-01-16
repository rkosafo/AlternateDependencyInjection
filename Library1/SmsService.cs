using Library1.Interfaces;
using System;
using System.Threading.Tasks;

namespace Library1
{
    public static class SmsService
    {
        private static ISmsService _impl = default;

        public static async Task<(string id, Exception error)> send(ISmsMessage message)
        {
            if (_impl != null) return await _impl.send(message);
            return (default, new NotImplementedException());
        }

        public static void setImplementation(ISmsService implementation)
        {
            _impl = implementation;
        }

        public static void setImplementation<T>() where T: ISmsService, new()
        {
            setImplementation(new T());
        }
    }
}
using Library1.Interfaces;
using System;

namespace Library1
{
    public static class UssdService
    {
        private static IUssdService _impl = default;
        private static Func<IUssdService> createFn = default;

        public static IUssdService singleton => _impl;
        public static IUssdService transient() => createFn();

        private static void setImplementation(IUssdService implementation)
        {
            _impl = implementation;
        }

        public static void setImplementation<T>() where T: IUssdService, new()
        {
            createFn = () => new T();
            setImplementation(createFn());
        }
    }
}
using ImplementationLibrary1;
using Library1;
using Microsoft.Extensions.DependencyInjection;

namespace AltDependencyManagement.DependencyInjection
{
    public static class AltDIConfig
    {
        public static void init(IServiceCollection services)
        {
            SmsService.setImplementation<HubtelSmsService>();
            EmailService.setImplementation<ElasticEmailService>();
            UssdService.setImplementation<NaloUssdService>();
        }
    }
}

using Library1;
using Library1.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltDependencyManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sendSms")]
        public async Task<IActionResult> Get()
        {
            var ret = await SmsService.send(new SmsMessage
            {
                message = "Hello World",
                phoneNumber = "+2331234"
            });
            if (ret.error != null) return BadRequest(ret.error.GetBaseException().Message);
            return Ok(ret.id);
        }

        [HttpPost("sendEmail")]
        public async Task<IActionResult> sendEmail(EmailMessage message)
        {
            var ret = await EmailService.send(message);
            if (ret.error != null) return BadRequest(ret.error.GetBaseException().Message);
            return Ok(ret.id);
        }

        [HttpPost("sendUssd")]
        public async Task<IActionResult> sendUssd(UssdMessage message)
        {
            var ret = await UssdService.singleton.send(message);
            if (ret.error != null) return BadRequest(ret.error.GetBaseException().Message);
            ret = await UssdService.transient().send(message);
            if (ret.error != null) return BadRequest(ret.error.GetBaseException().Message);
            return Ok(ret.id);
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;

namespace SomeAspCoreProject.Services
{
    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfigurationRoot configuration)
        {
            _greeting = configuration["greetmessage"];
        }
        public string GetGreeting()
        {
            return $"{_greeting} from service";
        }
    }
}

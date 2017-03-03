using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetGreeting();
    }
    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration configuration)
        {
            _greeting = configuration["greeting"];
        }
        string IGreeter.GetGreeting()
        {
            return _greeting;
        }
    }
}
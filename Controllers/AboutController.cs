using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "695-2190";
        }

        public string Country()
        {
            return "Iceland";
        }
    }

}
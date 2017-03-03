using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IResturantData _resturantData;
        public HomeController(IResturantData resturantData)
        {
            _resturantData = resturantData;
        }
        public IActionResult Index()
        {   
            var model = _resturantData.GetAll();

            return View(model);
        }
    }

}
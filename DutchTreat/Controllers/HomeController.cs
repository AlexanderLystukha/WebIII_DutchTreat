using DutchTreat.Data;
using DutchTreat.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DutchTreat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDutchRepository _repository;

        public HomeController(ILogger<HomeController> logger, IDutchRepository repository)
        {            
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Header = "Contact Us Today";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();

            return View(results);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

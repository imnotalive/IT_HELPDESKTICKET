using IT_HELPDESKTICKET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EntityLayers.EF;

namespace IT_HELPDESKTICKET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ILogger<HomeController> _logger;
        POTA_PTKSEntities db = new POTA_PTKSEntities();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

     
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }



    }
}
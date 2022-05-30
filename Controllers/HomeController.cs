using il_mio_primo_blog.Models;
using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;

namespace il_mio_primo_blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*ViewData["Message"] = "Hello " + Nome;
            ViewData["NumTimes"] = Num;*/

            return View();
        }


       

        /*public string index(string Nome ,int iNum)
        {
            string sAppo = "ciao da " + Nome + "\n";
            for (int i = 0; i < iNum; i++)
                sAppo += "ciao da " + Nome + "\n";
            return sAppo;
        }*/

        public IActionResult index1()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
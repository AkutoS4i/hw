using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLogin.Models;

namespace WebLogin.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LoginError()
        {
            return NotFound("Возникли проблемы со входом");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public RedirectResult Login(string username, string password)
        {
            string startUsername = "admin";
            string startPassword = "admin";
            if (startUsername.Equals(username) && startPassword.Equals(password))
            {
                return Redirect("~/Home/Index");
            }
            else return Redirect("~/HomeController/LoginError");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
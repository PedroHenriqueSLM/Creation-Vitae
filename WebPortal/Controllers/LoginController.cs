using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebPortal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

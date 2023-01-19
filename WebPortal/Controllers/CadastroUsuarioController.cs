using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebPortal.Controllers

{
    public class CadastroUsuarioController: Controller
    {
        public IActionResult Inclusao()
        {
            return View();
        }
    }
}

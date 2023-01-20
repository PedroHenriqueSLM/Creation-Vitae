using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace WebPortal.Controllers

{
    public class CadastroUsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        //public ActionResult EmailUnico(string Email)
        //{
        //    bool emailValido = false;

        //    emailValido = chamada a sua classe de verificacao de email com retorno(true / false)


        //    if (emailValido == true)
        //    {
        //        return Json(true, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(string.Format("E-mail '{0}' já esta cadastrado.", Email), JsonRequestBehavior.AllowGet);
        //    }
        //}


    }
}

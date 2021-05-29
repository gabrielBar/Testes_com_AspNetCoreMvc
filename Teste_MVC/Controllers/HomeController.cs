using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teste_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Divisao(int? Numerador=null, int? Denominador=null)
        {
            int? Resultado = null;
            ViewBag.Numerador = Numerador;
            ViewBag.Denominador = Denominador;
            if (Numerador!=null && Denominador!=null)
            {
                Resultado = Calcularora.Divide(Numerador.Value,Denominador.Value);
                ViewBag.Resultado = Resultado;
            }

            return View();
        }

    }
}
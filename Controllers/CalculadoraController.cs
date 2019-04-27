using Microsoft.AspNetCore.Mvc;

namespace dotNET_2019.Controllers {
    public class CalculadoraController : Controller {
        public ActionResult Index () {
            return View();
        }

        public ActionResult Somar (int n1, int n2) {
            ViewData["Resultado"] = n1 + n2;
            return View();
        }

        // public int Somar (int n1, int n2) {
        //     return n1 + n2;
        // }
    }
}
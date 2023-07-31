using Microsoft.AspNetCore.Mvc;

namespace ProjetoEstudo.Controllers
{
    public class PassageiroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }
    }
}

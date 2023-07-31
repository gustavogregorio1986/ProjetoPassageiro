using Microsoft.AspNetCore.Mvc;
using ProjetoEstudo.Models;
using ProjetoEstudo.Repositorio.Interface;

namespace ProjetoEstudo.Controllers
{
    public class PassageiroController : Controller
    {
        private readonly IPassageiroRepositorio _passageiroRepositorio;

        public PassageiroController(IPassageiroRepositorio passageiroRepositorio)
        {
            this._passageiroRepositorio = passageiroRepositorio;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PassageiroModel passageiro)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _passageiroRepositorio.Adicionar(passageiro);
                    TempData["MensagemSucesso"] = "Passageiro cadastrado com sucesso";
                    return RedirectToAction("Consultar");
                }

                return View(passageiro);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Passageiro não foi cadastrado, tente novamente, erro: {erro.Message}";
                return RedirectToAction("Consultar");
            }
        }

        public IActionResult Consultar()
        {
            return View();
        }
    }
}

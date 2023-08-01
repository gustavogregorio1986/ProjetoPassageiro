using Microsoft.AspNetCore.Mvc;
using ProjetoEstudo.Models;
using ProjetoEstudo.Repositorio.Interface;
using System.Collections.Generic;

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

        public IActionResult ApagarConfirmacao(int id)
        {
            PassageiroModel passageiro = _passageiroRepositorio.ListarPorId(id);
            return View(passageiro);
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
            List<PassageiroModel> listar = _passageiroRepositorio.ListarTodos();
            return View(listar);
        }

        public IActionResult Editar(int id)
        {
            PassageiroModel passageiro = _passageiroRepositorio.ListarPorId(id);
            return View(passageiro);
        }

        [HttpPost]
        public IActionResult Alterar(PassageiroModel passageiro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _passageiroRepositorio.Atualizar(passageiro);
                    TempData["MensagemSucesso"] = "Passageiro atualizado com sucesso";
                    return RedirectToAction("Consultar");
                }
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Passageiro não foi atualizado, tente novamente, erro: {erro.Message}";
                return RedirectToAction("Consultar");
            }

            return View("Editar", passageiro);
        }
    }
}

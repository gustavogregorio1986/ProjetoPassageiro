using ProjetoEstudo.Data;
using ProjetoEstudo.Models;
using ProjetoEstudo.Repositorio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEstudo.Repositorio
{
    public class PassageiroRepositorio : IPassageiroRepositorio
    {
        private readonly BancoContext _bancoContext;

        public PassageiroRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public PassageiroModel Adicionar(PassageiroModel passageiro)
        {
            _bancoContext.Passageiros.Add(passageiro);
            _bancoContext.SaveChanges();

            return passageiro;
        }

        public List<PassageiroModel> ListarTodos()
        {
            return _bancoContext.Passageiros.ToList();
        }
    }
}

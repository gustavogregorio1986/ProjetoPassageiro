using ProjetoEstudo.Data;
using ProjetoEstudo.Models;
using ProjetoEstudo.Repositorio.Interface;

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
    }
}

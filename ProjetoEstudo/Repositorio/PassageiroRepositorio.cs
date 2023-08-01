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

        public bool Apagar(int id)
        {
            PassageiroModel passageirodb = ListarPorId(id);

            if (passageirodb == null) throw new System.Exception("Houve um erro para apagar o passageiro");

            _bancoContext.Passageiros.Remove(passageirodb);
            _bancoContext.SaveChanges();

            return true;
        }

        public PassageiroModel Atualizar(PassageiroModel passageiro)
        {
            PassageiroModel passageirodb = ListarPorId(passageiro.Id);

            if (passageirodb == null) throw new System.Exception("Houve erro ao autalizar o passageiro");

            passageirodb.Nome = passageiro.Nome;
            passageirodb.Email = passageiro.Email;
            passageirodb.NumeroPoltrona = passageiro.NumeroPoltrona;
            passageirodb.Compania = passageiro.Compania;
            passageirodb.Origem = passageiro.Origem;
            passageirodb.Destino = passageiro.Destino;

            _bancoContext.Passageiros.Update(passageirodb);
            _bancoContext.SaveChanges();

            return passageirodb;
        }

        public PassageiroModel ListarPorId(int id)
        {
            return _bancoContext.Passageiros.FirstOrDefault(x => x.Id == id);
        }

        public List<PassageiroModel> ListarTodos()
        {
            return _bancoContext.Passageiros.ToList();
        }
    }
}

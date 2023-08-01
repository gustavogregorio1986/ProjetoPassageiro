using ProjetoEstudo.Models;
using System.Collections.Generic;

namespace ProjetoEstudo.Repositorio.Interface
{
    public interface IPassageiroRepositorio
    {
        PassageiroModel Adicionar(PassageiroModel passageiro);

        List<PassageiroModel> ListarTodos();

        PassageiroModel ListarPorId(int id);

        PassageiroModel Atualizar(PassageiroModel passageiro);

        bool Apagar(int id);
    }
}

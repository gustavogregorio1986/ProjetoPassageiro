using ProjetoEstudo.Models;
using System.Collections.Generic;

namespace ProjetoEstudo.Repositorio.Interface
{
    public interface IPassageiroRepositorio
    {
        PassageiroModel Adicionar(PassageiroModel passageiro);

        List<PassageiroModel> ListarTodos();
    }
}

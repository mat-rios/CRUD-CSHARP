using ProjetoPizzaria.Models;
using System.Collections.Generic;

namespace ProjetoPizzaria.Repositorio
{
    public interface IEstoqueRepositorio
    {
        EstoqueModel ListarPorId(int id);
        List<EstoqueModel> BuscarTodos();
        EstoqueModel Adicionar(EstoqueModel produto);
        EstoqueModel Atualizar(EstoqueModel produto);

        bool Apagar(int id);
    }
}

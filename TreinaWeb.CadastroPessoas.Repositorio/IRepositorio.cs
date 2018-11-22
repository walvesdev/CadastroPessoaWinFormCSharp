using CadastroPessoas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CadastroPessoas.Repositorio
{
    public interface IRepositorio<T>
    {
        List<T> SelecionarTodos();
        List<T> Selecionar(Func<T, bool> whereClause);
        int Adicionar(T objeto);
    }
}

using CadastroPessoas.Dominio;
using CadastroPessoas.Persistencia.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CadastroPessoas.Repositorio
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        public int Adicionar(Pessoa objeto)
        {
            CadastroPessoaDbContext banco = new CadastroPessoaDbContext();
            banco.Pessoas.Add(objeto);
            return banco.SaveChanges();
        }

        public List<Pessoa> SelecionarTodos()
        {
            CadastroPessoaDbContext banco = new CadastroPessoaDbContext();
            List<Pessoa> pessoas = banco.Pessoas.AsParallel().OrderBy(p => p.Nome).ToList();
            banco.Dispose();
            return pessoas;
        }
        public List<Pessoa> Selecionar(Func<Pessoa, bool> whereClause)
        {
            CadastroPessoaDbContext banco = new CadastroPessoaDbContext();
            List<Pessoa> pessoas = banco.Pessoas.AsParallel().Where(whereClause).ToList();
            banco.Dispose();
            return pessoas;
        }
    }
}

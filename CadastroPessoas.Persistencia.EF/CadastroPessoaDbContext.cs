using CadastroPessoas.Dominio;
using System.Data.Entity;

namespace CadastroPessoas.Persistencia.EF
{
    public class CadastroPessoaDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
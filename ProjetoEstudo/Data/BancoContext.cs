using Microsoft.EntityFrameworkCore;
using ProjetoEstudo.Models;

namespace ProjetoEstudo.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<PassageiroModel> Passageiros { get; set; }
    }
}

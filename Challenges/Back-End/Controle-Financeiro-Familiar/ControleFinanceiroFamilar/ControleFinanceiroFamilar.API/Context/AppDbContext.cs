using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<Despesas> Despesas { get; set; }
    }
}

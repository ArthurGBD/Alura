using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using ControleFinanceiroFamilar.Modelos.Modelos.Resumo;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
 
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Resumo> Resumos { get; set; }
    }
}

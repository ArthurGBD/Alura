using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //    //mb.Entity<Despesa>()
            //    //    .HasOne(despesa => despesa.Resumo)
            //    //    .WithMany(resumo => resumo.Despesas)
            //    //    .HasForeignKey(despesa => despesa.ResumoId);

            //    //mb.Entity<Receita>()
            //    //    .HasOne(receita => receita.Resumo)
            //    //    .WithMany(resumo => resumo.Receitas)
            //    //    .HasForeignKey(receita => receita.ResumoId);

            mb.Entity<Resumo>()
                .HasKey(c => c.DespesasByCategoria);

        }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Resumo> Resumos { get; set; }
    }
}

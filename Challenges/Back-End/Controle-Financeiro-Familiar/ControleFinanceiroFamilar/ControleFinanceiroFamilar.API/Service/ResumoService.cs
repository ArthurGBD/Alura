using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Service
{
    public class ResumoService : IResumoService
    {
        private readonly AppDbContext _context;

        public ResumoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Resumo>> GetResumoData(int mes, int ano)
        {
            //    var resumo = await _context.Resumos.Where(resumo =>
            //        resumo.Mes == mes && resumo.Ano == ano).ToListAsync();

            //if (resumo.Count == 0)
            //{
            //    return null;
            //}

            var resumo = await _context.Resumos.FirstOrDefaultAsync(resumo =>
            resumo.Mes == mes && resumo.Ano == ano
            );

            var resumoByCategoraList = new List<Resumo>();
            
            if (resumo == null)
            {
                return null;
            }

            if (resumo.Id < 0)
            {
                resumo.DespesasTotal = GetTotalDespesas(resumo.Despesas);
                resumo.ReceitasTotal = GetTotalReceitas(resumo.Receitas);
                resumo.Saldo = resumo.ReceitasTotal - resumo.DespesasTotal;
                resumo.DespesasByCategoria = GetDespesasByCategoria(resumo.DespesasByCategoria);
                return resumo;
            }


        }

        //private Dictionary<Categoria, double> GetDespesasByCategoria(Dictionary<Categoria, double> despesasByCategoria)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Resumo> AddResumo(Resumo resumo)
        {
            var resumoJaCadastrado = _context.Resumos.FirstOrDefault(r =>
                r.Ano == resumo.Ano && r.Mes == resumo.Mes);

            if (resumoJaCadastrado == null)
            {
                var result = await _context.Resumos.AddAsync(resumo);
                _context.SaveChanges();

                return result.Entity;
            }

            return null;
        }

        private async Task<Dictionary<Categoria, double>> GetDespesasByCategoria(List<Despesa> despesaMes)
        {
            var despesaByCategoria = new Dictionary<Categoria, double>();

            var despesaQuery =
                from despesa in despesaMes
                group despesa by despesa.Categoria into g
                select new
                {
                    g.Key,
                    ValorTotal = g.Sum(despesa => despesa.Valor), /// Tentar fazer list
                };

            foreach (var despesa in despesaQuery)
                despesaByCategoria.Add(despesa.Key, despesa.ValorTotal);

            List<Dictionary<Categoria, Despesa>> recebeToList = despesaByCategoria.ToList().;  

            return despesaByCategoria;
        }

        public double GetTotalDespesas(List<Despesa> despesaMes)
        {
            var valores = from despesa in despesaMes
                          select despesa.Valor;

            return valores.Sum();
        }

        public double GetTotalReceitas(List<Receita> receitasMes)
        {
            var valores = from receita in receitasMes
                          select receita.Valor;

            return valores.Sum();
        }
    }
}

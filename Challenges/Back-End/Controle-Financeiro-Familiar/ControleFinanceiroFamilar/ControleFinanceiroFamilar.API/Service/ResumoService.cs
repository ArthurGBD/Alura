using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;

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
            var resumo = _context.Resumos.FirstOrDefault(resumo =>
                resumo.Mes == mes && resumo.Ano == ano);

            if (resumo == null) return null;


        }
        public async Task<Resumo> AddResumo(Resumo resumo)
        {
            var resumoJaCadastro = _context.Resumos.FirstOrDefault(r =>
                r.Ano == resumo.Ano && r.Mes == resumo.Mes);

            if (resumoJaCadastro == null)
            {
                _context.Resumos.Add(resumo);
                _context.SaveChanges();

                return _
            }
        }

        public async Task<Dictionary<Categoria, double>> GetDespesasByCategoria(List<Despesa> despesaMes)
        {
            var despesaByCategoria = new Dictionary<Categoria, double>();

            var despesaQuery =
                from despesa in despesaMes
                group despesa by despesa.Categoria into g
                select new
                {
                    g.Key,
                    ValorTotal = g.Sum(despesa => despesa.Valor),
                };

            foreach (var despesa in despesaQuery)
                despesaByCategoria.Add(despesa.Key, despesa.ValorTotal);

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

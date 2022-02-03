using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;

namespace ControleFinanceiroFamilar.API.Service
{
    public interface IResumoService
    {
        Task<List<Resumo>> GetResumoData(int mes, int ano);
        Task<Resumo> AddResumo(Resumo resumo);
        Task<Dictionary<Categoria, double>> GetDespesasByCategoria(List<Despesa> despesaMes);
        public double GetTotalDespesas(List<Despesa> despesaMes);
        public double GetTotalReceitas(List<Receita> receitasMes);
    }
}

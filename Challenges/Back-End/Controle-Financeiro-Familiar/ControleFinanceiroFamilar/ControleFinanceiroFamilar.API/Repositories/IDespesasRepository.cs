using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;

namespace ControleFinanceiroFamilar.API.Repositories
{
    public interface IDespesasRepository
    {
        Task<IEnumerable<Despesas>> GetDespesas();
        Task<Despesas> GetDespesa(int id);
        Task<Despesas> AddDespesa(Despesas despesa);
        Task<Despesas> UpdateDespesa(Despesas despesa);
        Task<Despesas> DeleteDespesa(int id);
    }
}

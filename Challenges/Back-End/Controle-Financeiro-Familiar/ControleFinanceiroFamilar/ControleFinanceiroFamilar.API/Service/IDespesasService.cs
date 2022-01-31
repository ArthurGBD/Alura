using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;

namespace ControleFinanceiroFamilar.API.Service
{
    public interface IDespesasService
    {
        Task<IEnumerable<Despesa>> GetDespesas();
        Task<Despesa> GetDespesasByMonth(string descricao, int mes, int ano);
        Task<Despesa> GetDespesaById(int id);
        Task<Despesa> AddDespesa(Despesa despesa);
        Task<Despesa> UpdateDespesa(int id, Despesa despesa);
        Task<Despesa> DeleteDespesa(int id);
        public bool ValidarDuplicidadeDaDespesa(Despesa despesas);
        public bool ValidarDuplicidadeDaDespesa(int id, Despesa despesas);
    }
}

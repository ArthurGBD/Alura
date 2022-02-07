using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;

namespace ControleFinanceiroFamilar.API.Service
{
    public interface IDespesasService
    {
        Task<IEnumerable<Despesa>> GetDespesas();
        Task<Despesa> GetDespesaById(int id);
        Task<List<Despesa>> GetDespesasByData(int mes, int ano, Categoria categoria = Categoria.Outras);
        Task<List<Despesa>> GetDespesasByDescricao(string descricao);
        Task<Despesa> AddDespesa(Despesa despesa, Categoria categoria);
        Task<Despesa> UpdateDespesa(int id, Despesa despesa);
        Task<Despesa> DeleteDespesa(int id);

        //public bool VerificarCompatibilidadeResumo(Despesa despesa);
        public bool ValidarDuplicidadeDaDespesa(Despesa despesas);
        public bool ValidarDuplicidadeDaDespesa(int id, Despesa despesas);
    }
}

using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;

namespace ControleFinanceiroFamilar.API.Repositories
{
    public interface IReceitasRepository
    {
        Task<IEnumerable<Receitas>> GetReceitas();
        Task<Receitas> GetReceita(int id);
        Task<Receitas> AddReceita(Receitas receitas);
        Task<Receitas> UpdateReceita(Receitas receitas);
        Task<Receitas> DeleteReceita(int id);
    }
}

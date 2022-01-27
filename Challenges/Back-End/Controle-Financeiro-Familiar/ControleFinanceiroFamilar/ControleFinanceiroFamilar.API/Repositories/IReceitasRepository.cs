using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;

namespace ControleFinanceiroFamilar.API.Repositories
{
    public interface IReceitasRepository
    {
        Task<IEnumerable<Receitas>> GetReceitas();
        Task<Receitas> GetReceitaById(int id);
        Task<Receitas> GetReceitasByDescricao(string descricao, int mes, int ano);
        Task<Receitas> AddReceita(Receitas receitas);
        Task<Receitas> UpdateReceita(Receitas receitas);
        Task<Receitas> DeleteReceita(int id);

      
    }
}

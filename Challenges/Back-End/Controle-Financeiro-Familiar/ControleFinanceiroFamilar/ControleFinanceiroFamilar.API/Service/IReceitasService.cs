using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;

namespace ControleFinanceiroFamilar.API.Service
{
    public interface IReceitasService
    {
        Task<IEnumerable<Receita>> GetReceitas();
        Task<Receita> GetReceitasByDescricao(string descricao);
        Task<Receita> GetReceitasByData(int mes, int ano);
        Task<Receita> GetResumoReceitas(string descricao);
        Task<Receita> GetReceitaById(int id);
        Task<Receita> AddReceita(Receita receitas);
        Task<Receita> UpdateReceita(int id, Receita receitas);
        Task<Receita> DeleteReceita(int id);
        public bool ValidarDuplicidadeDaReceita(Receita receitas);
        public bool ValidarDuplicidadeDaReceita(int id, Receita receitas);
        

        
    }
}

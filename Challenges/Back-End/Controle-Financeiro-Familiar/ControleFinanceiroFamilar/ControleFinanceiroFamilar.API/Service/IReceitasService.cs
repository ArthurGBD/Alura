using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;

namespace ControleFinanceiroFamilar.API.Service
{
    public interface IReceitasService
    {
        Task<IEnumerable<Receita>> GetReceitas();
        Task<Receita> GetReceitaById(int id);
        Task<List<Receita>> GetReceitasByData(int mes, int ano);
        Task<List<Receita>> GetReceitasByDescricao(string descricao);
        Task<Receita> AddReceita(Receita receitas);
        Task<Receita> UpdateReceita(int id, Receita receitas);
        Task<Receita> DeleteReceita(int id);
        //public bool VerificarCompatibilidadeResumo(Receita receita);
        public bool ValidarDuplicidadeDaReceita(Receita receitas);
        public bool ValidarDuplicidadeDaReceita(int id, Receita receitas);
        

        
    }
}

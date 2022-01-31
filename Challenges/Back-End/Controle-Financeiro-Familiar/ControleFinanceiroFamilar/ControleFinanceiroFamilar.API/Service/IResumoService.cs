namespace ControleFinanceiroFamilar.API.Service
{
    public interface IResumoService
    {
        Task<string> Get(string id);
    }
}

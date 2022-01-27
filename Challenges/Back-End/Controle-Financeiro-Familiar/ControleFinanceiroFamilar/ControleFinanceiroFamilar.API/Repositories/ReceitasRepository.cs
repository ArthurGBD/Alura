using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Repositories
{
    public class ReceitasRepository : IReceitasRepository
    {

        private readonly AppDbContext _context;

        public ReceitasRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Receitas>> GetReceitas()
        {
            return await _context.Receitas.AsNoTracking().ToListAsync();
        }

        public async Task<Receitas> GetReceitaById(int id)
        {
            return await _context.Receitas.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Receitas> AddReceita(Receitas receitas)
        {
            var receitaJaCadastrada = GetReceitasByDescricao(receitas.Descricao, receitas.Data.Month, receitas.Data.Year);

            if (receitaJaCadastrada == null)
            {
                var result = await _context.Receitas.AddAsync(receitas);
                await _context.SaveChangesAsync();
                return result.Entity;

            }

            return null;
        }

        public async Task<Receitas> GetReceitasByDescricao(string descricao, int mes, int ano)
        {
            var receitaIgualCadastrada = await _context.Receitas
               .FirstOrDefaultAsync(receitas => receitas.Descricao == descricao &&
               receitas.Data.Month == mes && receitas.Data.Year == ano
               );

            return receitaIgualCadastrada;

        }


        public async Task<Receitas> UpdateReceita(Receitas receitas)
        {
            var result = _context.Receitas.FirstOrDefault(c => c.Id == receitas.Id);
            if (result != null)
            {
                result.Descricao = receitas.Descricao;
                result.Valor = receitas.Valor;
                result.Data = receitas.Data;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task<Receitas> DeleteReceita(int id)
        {
            var receita = _context.Receitas.FirstOrDefault(c => c.Id == id);
            if (receita != null)
            {
                _context.Receitas.Remove(receita);
                await _context.SaveChangesAsync();
            }
            return null;
        }
    }
}

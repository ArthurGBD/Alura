using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Repositories
{
    public class DespesasRepository : IDespesasRepository
    {
        private readonly AppDbContext _context;

        public DespesasRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Despesas>> GetDespesas()
        {
            return await _context.Despesas.AsNoTracking().ToListAsync();
        }

        public async Task<Despesas> GetDespesa(int id)
        {
            return await _context.Despesas.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Despesas> AddDespesa(Despesas despesa)
        {
            var result = await _context.Despesas.AddAsync(despesa);
            await _context.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<Despesas> UpdateDespesa(Despesas despesa)
        {
            var result = _context.Despesas.FirstOrDefault(c => c.Id == despesa.Id);
            if (result != null)
            {
                result.Descricao = despesa.Descricao;
                result.Valor = despesa.Valor;
                result.Data = despesa.Data;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task<Despesas> DeleteDespesa(int id)
        {
            var despesa = _context.Despesas.FirstOrDefault(c => c.Id == id);
            if (despesa != null)
            {
                _context.Despesas.Remove(despesa);
                await _context.SaveChangesAsync();
            }
            return null;
        }
    }
}


using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Service
{
    public class DespesasService : IDespesasService
    {
        private readonly AppDbContext _context;

        public DespesasService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Despesa>> GetDespesas()
        {
            return await _context.Despesas.AsNoTracking().ToListAsync();
        }

        public async Task<Despesa> GetDespesaById(int id)
        {
            return await _context.Despesas.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Despesa> GetDespesasByMonth(string descricao, int mes, int ano)
        {
            return await _context.Despesas.FirstOrDefaultAsync(despesa =>
            despesa.Descricao == descricao &&
            despesa.Data.Month == mes &&
            despesa.Data.Year == ano);
        }

        public async Task<Despesa> AddDespesa(Despesa despesa)
        {
            var despesaDuplicada = ValidarDuplicidadeDaDespesa(despesa);

            if (!despesaDuplicada)
            {
                var result = await _context.Despesas.AddAsync(despesa);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            return null;
        }


        public async Task<Despesa> UpdateDespesa(int id, Despesa despesa)
        {
            var result = _context.Despesas.FirstOrDefault(c => c.Id == despesa.Id);
            if (result != null)
            {
                var despesaDuplicada = ValidarDuplicidadeDaDespesa(id, despesa);

                if (!despesaDuplicada)
                {
                    result.Descricao = despesa.Descricao;
                    result.Valor = despesa.Valor;
                    result.Data = despesa.Data;
                    await _context.SaveChangesAsync();
                    return result;
                }
            }
            return null;
        }
        public async Task<Despesa> DeleteDespesa(int id)
        {
            var despesa = _context.Despesas.FirstOrDefault(c => c.Id == id);
            if (despesa != null)
            {
                _context.Despesas.Remove(despesa);
                await _context.SaveChangesAsync();
            }
            return null;
        }

        public bool ValidarDuplicidadeDaDespesa(Despesa despesas)
        {
            var possivelDespesaDuplciada = _context.Despesas.FirstOrDefault(despesa =>
                despesa.Descricao == despesas.Descricao &&
                despesa.Data.Month == despesas.Data.Month &&
                despesa.Data.Year == despesas.Data.Year
                );
            if (possivelDespesaDuplciada != null)
            {
            return true;
            }

            return false;
        }
        public bool ValidarDuplicidadeDaDespesa(int id, Despesa despesas)
        {
            var possivelDespesaDuplicada = _context.Despesas.FirstOrDefault(despesa =>
            despesa.Descricao == despesas.Descricao &&
            despesa.Data.Month == despesas.Data.Month &&
            despesa.Data.Year == despesas.Data.Year
            );

            if (possivelDespesaDuplicada == null) return false;
            
            if (possivelDespesaDuplicada.Id == id) return false;

            return true;
        }
    }
}


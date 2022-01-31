using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroFamilar.API.Service
{
    public class ReceitasService : IReceitasService
    {

        private readonly AppDbContext _context;

        public ReceitasService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Receita>> GetReceitas()
        {
            return await _context.Receitas.AsNoTracking().ToListAsync();
        }
        public async Task<Receita> GetReceitaById(int id)
        {
            return await _context.Receitas.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Receita> GetReceitasByMonth(string descricao)
        {
            return await _context.Receitas.FirstOrDefaultAsync(receita => receita.Descricao == descricao);
        }
        public async Task<Receita> AddReceita(Receita receitas)
        {
            var receitaDuplicada = ValidarDuplicidadeDaReceita(receitas);

            if (!receitaDuplicada)
            {
                var result = await _context.Receitas.AddAsync(receitas);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            return null;
        }
        public async Task<Receita> UpdateReceita(int id, Receita receitas)
        {
            var result = _context.Receitas.FirstOrDefault(c => c.Id == receitas.Id);
            if (result != null)
            {
                var receitaDuplicada = ValidarDuplicidadeDaReceita(id, receitas);

                if (!receitaDuplicada)
                {
                    result.Descricao = receitas.Descricao;
                    result.Valor = receitas.Valor;
                    result.Data = receitas.Data;
                    await _context.SaveChangesAsync();
                    return result;
                }
            }
            return null;
        }
        public async Task<Receita> DeleteReceita(int id)
        {
            var receita = _context.Receitas.FirstOrDefault(c => c.Id == id);
            if (receita != null)
            {
                _context.Receitas.Remove(receita);
                await _context.SaveChangesAsync();
            }
            return null;
        }
        public bool ValidarDuplicidadeDaReceita(Receita receitas)
        {
            var possivelReceitaDuplicada = _context.Receitas.FirstOrDefault(receita =>
                receita.Descricao == receitas.Descricao &&
                receita.Data.Month == receitas.Data.Month &&
                receita.Data.Year == receitas.Data.Year
                );

            if (possivelReceitaDuplicada != null)
            {
                return true;
            }

            return false;
        }
        public bool ValidarDuplicidadeDaReceita(int id, Receita receitas)
        {
            var possivelReceitaDuplicada = _context.Receitas.FirstOrDefault(receita =>
            receita.Descricao == receitas.Descricao &&
            receita.Data.Month == receitas.Data.Month &&
            receita.Data.Year == receitas.Data.Year
            );

            if (possivelReceitaDuplicada == null)
            {
                return false;
            }

            if (possivelReceitaDuplicada.Id == id)
            {
                return false;
            }

            return true;
        }
    }
}

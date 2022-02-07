using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
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
        public async Task<List<Despesa>> GetDespesasByData(int mes, int ano, Categoria categoria = Categoria.Outras)
        {
            var despesas = await _context.Despesas.Where(despesa
                            => despesa.Data.Month == mes && despesa.Data.Year == ano && categoria != 0).ToListAsync();

            //if (despesas.Count == 0 || despesas == null)
            //{
            //    return null;
            //}

            return despesas;
        }
        public async Task<List<Despesa>> GetDespesasByDescricao(string descricao)
        {
            var despesas = await _context.Despesas.AsNoTracking().ToListAsync();

            if (despesas == null)
            {
                return null;
            }

            despesas.ToList().ForEach(d => d.Descricao = descricao);

            return despesas;
        }


        public async Task<Despesa> AddDespesa(Despesa despesa, Categoria categoria = 0)
        {
            var despesaDuplicada = ValidarDuplicidadeDaDespesa(despesa);

            //var compativelResumo = VerificarCompatibilidadeResumo(despesa);



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
                //bool compativelResumo = VerificarCompatibilidadeResumo(despesa);

                if (despesaDuplicada)
                {
                    return null;
                }
                //else if (compativelResumo)
                //{
                //    return null;
                //}
                else
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
                despesa.Data.Year == despesas.Data.Year &&
                despesa.Categoria == despesas.Categoria
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

        //public bool VerificarCompatibilidadeResumo(Despesa despesa)
        //{
        //    var resultResumo = _context.Resumos.FirstOrDefault(r => r.Id == despesa.ResumoId);

        //    if (resultResumo == null) return false;
        //    else if (resultResumo.Ano != despesa.Data.Year || resultResumo.Mes != despesa.Data.Month)
        //        return false;

        //    return true;
        //}

       

    }
}


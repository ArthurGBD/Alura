using ControleFinanceiroFamilar.API.Context;
using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ControleFinanceiroFamilar.API.Service
{
    public class ResumoService : IResumoService
    {
        private readonly AppDbContext _context;

        public ResumoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Resumo>> GetResumoData(int mes, int ano)
        {
            var resumo = await _context.Resumos.FirstOrDefaultAsync(resumo =>
            resumo.Mes == mes && resumo.Ano == ano
            );

            if (resumo == null)
            {
                return null;
            }

            if (resumo != null)
            {
                var despesa = new Despesa { };
                var receita = new Receita { };

                var resumoByCategoraList = new List<Resumo>(CalculaResumo(resumo, despesa, receita));
                
                return resumoByCategoraList;
            }

            return null;
        }

        public async Task<Resumo> AddResumo(Resumo resumo)
        {
            var resumoJaCadastrado = _context.Resumos.FirstOrDefault(r =>
                r.Ano == resumo.Ano && r.Mes == resumo.Mes);

            if (resumoJaCadastrado == null)
            {
                var result = await _context.Resumos.AddAsync(resumo);
                _context.SaveChanges();

                return result.Entity;
            }

            return null;
        }

        public Dictionary<Categoria, double> GetDespesasByCategoria(List<Despesa> despesaMes)
        {
            var despesaByCategoria = new Dictionary<Categoria, double>();

            var despesaQuery =
                from despesa in despesaMes
                group despesa by despesa.Categoria into g
                select new
                {
                    g.Key,
                    ValorTotal = g.Sum(despesa => despesa.Valor),
                };

            foreach (var despesa in despesaQuery)
                despesaByCategoria.Add(despesa.Key, despesa.ValorTotal);

            return despesaByCategoria;
        }

        public double GetTotalDespesas(List<Despesa> despesaMes)
        {
            var valores = from despesa in despesaMes
                          select despesa.Valor;

            return valores.Sum();
        }

        public double GetTotalReceitas(List<Receita> receitasMes)
        {
            var valores = from receita in receitasMes
                          select receita.Valor;

            return valores.Sum();
        }

        public List<Resumo> CalculaResumo(Resumo resumo, Despesa despesa, Receita receita)
        {

            var despesaList = new List<Despesa> { despesa };
            var resumoList = new List<Resumo>();

            resumo.DespesasTotal = resumo.DespesasTotal + despesa.Valor;
            resumo.ReceitasTotal = resumo.ReceitasTotal + receita.Valor;
            resumo.Saldo = resumo.ReceitasTotal - resumo.DespesasTotal;
            resumo.DespesasByCategoria = GetDespesasByCategoria(despesaList);

            resumoList.Add(resumo);

            return resumoList;

        }
    }
}

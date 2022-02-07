using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo
{
    public class Resumo
    {
        
        public int Id { get; set; }
        
        public int Mes { get; set; }
        
        public int Ano { get; set; }
        public double ReceitasTotal { get; set; }
        public double DespesasTotal { get; set; }
        public double Saldo { get; set; }
        
        
        public Dictionary<Categoria, double> DespesasByCategoria { get; set; }
        public List<Despesa> Despesas { get; set; }
       
        public List<Receita> Receitas { get; set; }
    }
}

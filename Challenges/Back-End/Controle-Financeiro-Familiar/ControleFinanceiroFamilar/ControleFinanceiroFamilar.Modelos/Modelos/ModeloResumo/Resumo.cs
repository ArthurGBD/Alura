using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo
{
    public class Resumo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public int Ano { get; set; }
        public double ReceitasTotal { get; set; }
        public double DespesasTotal { get; set; }
        public double Saldo { get; set; }
        public Dictionary<Categoria, double> DespesasByCategoria { get; set; }
        //public Categoria Categoria { get; set; }

        [JsonIgnore]
        public List<Despesa> Despesas { get; set; }
        [JsonIgnore]
        public List<Receita> Receitas { get; set; }
    }
}

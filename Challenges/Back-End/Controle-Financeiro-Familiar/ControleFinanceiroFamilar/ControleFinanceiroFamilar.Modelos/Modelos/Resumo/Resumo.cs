using ControleFinanceiroFamilar.Modelos.Modelos.Despesas;
using ControleFinanceiroFamilar.Modelos.Modelos.Receitas;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleFinanceiroFamilar.Modelos.Modelos.Resumo
{
    public class Resumo
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public int Ano { get; set; }
        [JsonIgnore]
        public virtual List<Despesa> Despesas { get; set; }
        [JsonIgnore]
        public virtual List<Receita> Receitas { get; set; }
    }
}

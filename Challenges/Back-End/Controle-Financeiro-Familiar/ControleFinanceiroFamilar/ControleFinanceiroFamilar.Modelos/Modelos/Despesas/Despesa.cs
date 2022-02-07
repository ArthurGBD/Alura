using ControleFinanceiroFamilar.Modelos.Modelos.Enums;
using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ControleFinanceiroFamilar.Modelos.Modelos.Despesas
{
    public class Despesa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a descrição de despesa!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Informe o valor da despesa!")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Informe a data desta despesa!")]
        [Column(TypeName = "DateTime2")]
        public DateTime Data { get; set; }
        [Required]
        public Categoria Categoria { get; set; } = 0;

        //public Resumo Resumo { get; set; }
      
        //public int ResumoId { get; set; }   

    }
}

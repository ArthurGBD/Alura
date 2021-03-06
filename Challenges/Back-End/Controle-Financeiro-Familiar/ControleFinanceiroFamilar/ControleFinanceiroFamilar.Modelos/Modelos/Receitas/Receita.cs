using ControleFinanceiroFamilar.Modelos.Modelos.ModeloResumo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroFamilar.Modelos.Modelos.Receitas
{
    public class Receita
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a descrição de receita!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Informe o valor da receita!")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Informe a data desta receita!")]
        [Column(TypeName = "dateTime2")]
        public DateTime Data { get; set; }
        //public Resumo Resumo { get; set; }
        
        //public int ResumoId { get; set; }
    }
}

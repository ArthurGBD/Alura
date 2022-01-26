using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroFamilar.Modelos.Modelos.Receitas
{
    public class Receitas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        [Column(TypeName = "dateTime2")]
        public DateTime Data { get; set; }
    }
}

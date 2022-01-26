using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroFamilar.Modelos.Modelos.Despesas
{
    public class Despesas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime Data { get; set; }

    }
}

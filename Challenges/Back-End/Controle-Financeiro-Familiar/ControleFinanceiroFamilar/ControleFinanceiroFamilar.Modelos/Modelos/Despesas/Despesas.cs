﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiroFamilar.Modelos.Modelos.Despesas
{
    public class Despesas
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a descrição de despesa!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Informe o valor da despesa!")]
        public double Valor { get; set; }
        
        [Required(ErrorMessage = "Informe a data desta despesa!")]
        [Column(TypeName = "DateTime2")]
        public DateTime Data { get; set; }

    }
}

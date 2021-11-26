using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);

            new ContaCorrente(123, 654564);

            Console.WriteLine(conta.Numero);

            DateTime dataFimPagamento = new DateTime(2021, 11, 25);

            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);


            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if (timeSpan.Days > 30)
        //    {
        //        int quanatidadeMeses = timeSpan.Days / 30;
        //        if (quanatidadeMeses == 1)
        //        {
        //            return "1 mês";
        //        }
        //        return quanatidadeMeses + "meses";
        //    }
        //    else if (timeSpan.Days > 7)
        //    {
        //        int quantidadeSemanas = timeSpan.Days / 7;
        //    }

        //    return timeSpan.Days + " dias";
        //}
    }


    
}

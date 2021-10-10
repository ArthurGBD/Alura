using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {

                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.WriteLine("Excecução finalizada. tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }
            

            //  *******************************************

            // USANDO O TRY E FINALLY

            //LeitorDeArquivo leitor1 = null;
            //try
            //{
            //    leitor1 = new LeitorDeArquivo("contas1.txt");

            //    leitor1.LerProximaLinha();
            //    leitor1.LerProximaLinha();
            //    leitor1.LerProximaLinha();

            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if (leitor1 != null)
            //    {
            //        leitor1.Dispose();
            //    }
            //}
        }
        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao - Dividir

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é" + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);

            new ContaCorrente(123, 654564);

            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("kfjdaskfsfs");
            
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}

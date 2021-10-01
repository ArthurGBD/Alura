using ByteBank.Funcionarios;
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
            GerenciadoBonificacao gerenciador = new GerenciadoBonificacao();

            Funcionario carlos = new Funcionario("546.879.157-20");

            //Funcionario pedro = new Diretor();

            carlos.Nome = "Carlos";
            
            carlos.Salario = 2000;

            Console.WriteLine(Funcionario.TotatlDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("455.132.131-5");

            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações" + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}

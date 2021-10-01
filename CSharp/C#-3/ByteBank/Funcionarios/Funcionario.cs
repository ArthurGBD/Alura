using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotatlDeFuncionarios { get; private set; }

        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public Funcionario( string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;

            TotatlDeFuncionarios++;
        }

        public virtual double GetBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }
            return Salario * 0.10;
        }
    }
}

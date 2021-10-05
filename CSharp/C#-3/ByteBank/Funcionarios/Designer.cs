using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
        }
        public override void AumentarSalario() => Salario *= 1.11;

        public override double Bonificacao => Salario * 0.17;
    }
}

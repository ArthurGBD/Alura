using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    internal class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf) 
            :base(salario, cpf)
        { 

        }
        public override void AumentarSalario()
        {
            //
        }

        protected override double GetBonificacao()
        {
            //
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerenteConta : Funcionario
    {
        public GerenteConta(string cpf) : base(4000, cpf)
        {
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Funcionarios
{
    public class GerenciadoBonificacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario) => _totalBonificacao += funcionario.Bonificacao;

        public double GetTotalBonificacao() => _totalBonificacao;
    }
}

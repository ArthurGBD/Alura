using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsufucienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsufucienteException() { }

        public SaldoInsufucienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com o saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsufucienteException(string mensagem) : base(mensagem) { }
        public SaldoInsufucienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna) { }
    }
}

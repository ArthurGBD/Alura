using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsarStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDeArquivo))
                {

                    //var linha = leitor.ReadLine();
                    //var linha = leitor.ReadToEnd();
                    //var linha = leitor.Read();

                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();

                        var contaCorrente = ConverterStringParaContaCorrente(linha);

                        var msg = $"Titular: {contaCorrente.Titular.Nome}, Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}, Saldo: {contaCorrente.Saldo}";

                        Console.WriteLine(msg);

                        //Console.WriteLine(linha);
                    }
                }
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}
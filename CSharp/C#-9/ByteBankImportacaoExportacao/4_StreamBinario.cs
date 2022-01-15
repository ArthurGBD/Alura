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
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrent.txt", FileMode.Create))
            {
                using (var escritor = new BinaryWriter(fs))
                {
                    escritor.Write(456);  // Número Agência
                    escritor.Write(456464);  // Número Conta
                    escritor.Write(4.0000);  // Saldo
                    escritor.Write("Arthur");
                }
            }
        }    
        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            {
                using (var leitor = new BinaryReader(fs))
                {
                    var agencia = leitor.ReadInt32();
                    var numeroConta = leitor.ReadInt32();
                    var saldo = leitor.ReadDouble();
                    var titular = leitor.ReadString();

                    Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
                }
            }
        }
    }
}
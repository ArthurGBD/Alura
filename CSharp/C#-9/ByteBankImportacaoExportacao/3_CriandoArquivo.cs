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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Gustavao Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);


                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }

        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {
                    escritor.Write("456,65656,456.0,Arthur");
                }
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {
                    for (int i = 0; i < 1000000000; i++)
                    {
                        escritor.WriteLine($"Linha {i}");

                        escritor.Flush(); // Despeja o buffer para o Stream

                        Console.WriteLine($"Linha {i} escrita, tecle enter para avançar");

                        Console.ReadLine();

                    }
                }
            }
        }
    }
}
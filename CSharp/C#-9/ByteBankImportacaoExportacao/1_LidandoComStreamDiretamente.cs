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
        static void LidadandoComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {

                var buffer = new byte[1024]; // 1 kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                    Console.WriteLine($"\nBytes lidos: {numeroDeBytesLidos}");

                    EscreverBuffer(buffer, numeroDeBytesLidos);

                }

            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            //var utf8 = new UTF8Encoding();
            //var utf8 = new UTF32Encoding();
            //var utf8 = Encoding.Default; // Padrão do SO
            var utf8 = Encoding.UTF8; // UTF8 Encoding

            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write("");
            //}
        }
    }
}
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
        static void Main(string[] args)
        {

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText()");
            Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");

            Console.WriteLine(linhas.Length);

            //UsarStreamDeEntrada();

            //LeituraBinaria();

            //CriarArquivo();
            //TestaEscrita();

            Console.ReadLine();
        }

        static void GuardaComentariosSobreAula()
        {
            //using (var fs = new FileStream("testaTipos.txt", FileMode.Create))
            //{
            //    using (var escritor = new StreamWriter(fs))
            //    {
            //        escritor.WriteLine(true);
            //        escritor.WriteLine(false);
            //        escritor.WriteLine(45645646546);
            //    }
            //}

            //var numero = 691693903;

            //using (var fs = new FileStream("c:/temp/BinaryWriter.txt", FileMode.Create))
            //using (var writer = new BinaryWriter(fs))
            //{
            //    writer.Write(numero);
            //}

            //using (var fs = new FileStream("c:/temp/StreamWriter.txt", FileMode.Create))
            //using (var writer = new StreamWriter(fs))
            //{
            //    writer.Write(numero);
            //}





            //var fs = new FileStream("teste.txt", FileMode.Open);

            //var buffer = new byte[1024];
            //var encoding = Encoding.ASCII;

            //var bytesLidos = fs.Read(buffer, 0, 1024);
            //var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

            //Console.Write(conteudoArquivo);


            //var arquivoOriginal = new FileStream("c:/temp/teste.txt", FileMode.Open);
            //var arquivoNovo = new FileStream("c:/temp/teste_copia.txt", FileMode.Create);
            //var buffer = new byte[1024];

            //using (arquivoOriginal)
            //using (arquivoNovo)
            //{
            //    var bytesLidos = -1;
            //    while (bytesLidos != 0)
            //    {
            //        bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
            //        arquivoNovo.Write(buffer, 0, bytesLidos);
            //    }
            //}

            //var rodape = Encoding.UTF8.GetBytes("Este documento é uma cópia do original");
            //arquivoNovo.Write(rodape, 0, rodape.Length);



        }
    }
}

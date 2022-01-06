 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlTeste = "https:www.bytebank.com/cambio";
            string indiceByteBank = "http://www.bytebank.com";

            Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
           
            Console.WriteLine(urlTeste.Contains("bytebank"));

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor); 

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaDestino: " + valor);
            Console.WriteLine(extratorDeValores.GetValor("valor"));

            //// pagina?argumentos
            //// 012345678


            ////string palavra = "moedaDestino=real";
            //string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            //string nomeArgumento = "moedaDestino";            

            //int indice = palavra.IndexOf(nomeArgumento);
            //Console.WriteLine(indice);
            
            //Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            //Console.WriteLine(palavra);
            //Console.WriteLine(palavra.Substring(indice));
            //Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "kjhfsdjhgsdfjksdf";


            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            //Console.ReadLine();

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogacao = url.IndexOf('?');

            //Console.WriteLine(indiceInterrogacao);

            //Console.WriteLine(url);
            //string argumentos = url.Substring(indiceInterrogacao + 1);
            //Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }


}

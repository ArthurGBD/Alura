 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente_1 = new Cliente();
            cliente_1.Nome = "Carlos";
            cliente_1.CPF = "458.623.120-03";
            cliente_1.Profissao = "Designer";

            Cliente cliente_2 = new Cliente();
            cliente_2.Nome = "Carlos";
            cliente_2.CPF = "458.623.120-03";
            cliente_2.Profissao = "Designer";

            ContaCorrente contaCorrente = new ContaCorrente(456, 1);

            if (cliente_1.Equals(cliente_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            //object conta = new ContaCorrente(1, 2);

            //Console.WriteLine(conta);


            //string padrao = "Sala [A-G][-]?[0123456789]{2}";

            //Console.WriteLine(Regex.IsMatch("Sala G345", padrao));
            //Console.WriteLine(Regex.IsMatch("Sala J-001", padrao));
            //Console.WriteLine(Regex.IsMatch("Sala a004", padrao));
            //Console.WriteLine(Regex.IsMatch("Sala C004", padrao));
            //Console.WriteLine(Regex.IsMatch("Minha sala é a sala G34", padrao));
            //Console.WriteLine(Regex.IsMatch("Minha sala é a Sala G-34", padrao));

            // "[0-9][0-9][0-9][0-9][ - ][0-9][0-9][0-9][0-9]"; // QUANTIFICADORES
            // "[0-9]{4}[ - ][0-9]{4}";
            // "[0-9]{4,5}[ - ][0-9]{4}";
            // "[0-9]{4,5}[ - ]{0,1}[0-9]{4}";
            // "[0-9]{4,5}-{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-?[0-9]{4}";

            //string textoDeTeste = "Meu nome é Arthur, me ligue em 4784-4546";

            //Match resultado = Regex.Match(textoDeTeste, padrao);

            //Console.WriteLine(resultado.Value);
            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));


            //string urlTeste = "https:www.bytebank.com/cambio";
            //string indiceByteBank = "http://www.bytebank.com";

            //Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com"));
            //Console.WriteLine(urlTeste.EndsWith("cambio/"));
           
            //Console.WriteLine(urlTeste.Contains("bytebank"));

            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            //ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //string valor = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valor); 

            //string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaDestino: " + valor);
            //Console.WriteLine(extratorDeValores.GetValor("valor"));

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

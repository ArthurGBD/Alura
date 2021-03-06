using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(123, 456),
                new ContaCorrente(456, 789),
                new ContaCorrente(121, 454),
                new ContaCorrente(34564, 6454),
                new ContaCorrente(1, 436),
            };

            //contas.Sort();
            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta =>
            //{
            //    if (conta == null)
            //    {
            //        return int.MinValue;
            //    }
            //    return conta.Numero;
            //});

            //var listaSemNulos = new List<ContaCorrente>();

            //foreach (var conta in contas)
            //{
            //    listaSemNulos.Add(conta);
            //}

            //var contasNaoNulas = contas.Where(conta => conta != null);

            //IOrderedEnumerable<ContaCorrente> contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);
            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy<ContaCorrente, int>(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia} ");
            }

            //List<int> idades = new List<int>();

            //var resultado = SomarVarios(1, 2, 3);

            //var conta = new ContaCorrente(344, 132132);
            //var gerenciador = new GerenciadorBonificacao();
            //var gerenciadores = new List<GerenciadorBonificacao>();


            //idades.Add(1);
            //idades.Add(5);
            //idades.Add(14);
            //idades.Add(25);
            //idades.Add(38);
            //idades.Add(61);


            //idades.AdicionarVarios(5, 448, 7898, 4564);

            // idades.Remove(5);

            //for (int i = 0; i < idades.Count; i++)
            //{
            //Console.WriteLine(idades[i]);
            //}

            //int[] a = new int[] {0, 1, 2 };
            //int[] b = new int[] {0, 1, 2 };

            //int[] resultado = a.Concatenar(); ERRO PARA TESTAR ATIVIDADE 

            Console.ReadLine();
        }


        static void TestaSort()
        {
            List<int> idades = new List<int>();

            var nomes = new List<string>()
            {
                "teste",
                "Arthur",
                "Zuleide"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            idades.AdicionarVarios(1, 2, 3);
            // ListExtensoes.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);

            idades.AdicionarVarios();

            idades.Sort();
        }
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar("um texto qualquer");
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }


        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }



        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}

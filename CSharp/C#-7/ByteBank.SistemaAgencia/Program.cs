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

            Lista<int> idades = new Lista<int>();

            idades.Adicionar(1);
            idades.AdicionarVarios(1, 2, 3);

            int idadeSoma = 0;

            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            //lista.MeuMetodoOpcional();
            //lista.MeuMetodoOpcional(numero: 10);

            lista.Adicionar(new ContaCorrente(37, 54656565));
            lista.Adicionar(new ContaCorrente(27, 5465656));
            lista.Adicionar(new ContaCorrente(17, 546565));
            lista.Adicionar(new ContaCorrente(17, 546565));
            lista.Adicionar(new ContaCorrente(17, 546565));
            lista.Adicionar(new ContaCorrente(17, 546565));
            lista.Adicionar(new ContaCorrente(17, 546565));
            lista.Adicionar(new ContaCorrente(17, 546565));
            lista.Adicionar(new ContaCorrente(17, 546565));
            lista.Adicionar(new ContaCorrente(17, 546565));

            ContaCorrente contaArthur = new ContaCorrente(999999999, 4554545);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaArthur,
                new ContaCorrente(37, 54656565),
                new ContaCorrente(37, 54656565)
            };

            lista.AdicionarVarios(contas);
            


            //lista.Adicionar(contaArthur);

            //lista.Remover(contaArthur);

            //Console.WriteLine("Após remover!");

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar(5);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(87, 54656565),
                new ContaCorrente(87, 54656),
                new ContaCorrente(87, 5465665)

            };

            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            //int[] idades = new int[5];

            int[] idades = null;
            idades = new int[5];

            idades[0] = 0;
            idades[1] = 1;
            idades[2] = 2;
            idades[3] = 3;
            idades[4] = 4;



            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades [{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");

            //int indice = 4;
            //int idadeNoIndice4 = idades[indice];

            //Console.WriteLine(idadeNoIndice4);

            //int[] outroArray = idades;

            //Console.WriteLine(outroArray[3]);

            //bool[] arrayDeBooleanos = new bool[10];
        }
    }
}

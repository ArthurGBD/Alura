using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T i in itens)
            {
                lista.Add(i);
            }
        }

        public static void TesteGenerico<T2>(this string texto)
        {
            string arhur = "Arhur";
            arhur.TesteGenerico<int>();
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(2);
            idades.Add(3);

            idades.AdicionarVarios<int>(1, 2, 2, 3);

            //ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4);

            List<string> nomes = new List<string>();
            nomes.Add("Teste");

            nomes.AdicionarVarios("teste", "teste");

            //ListExtensoes<string>.AdicionarVarios(nomes, "Arthur", "Arthur");
        }

        public static object[] Concatenar(this object[] a, object[] b)
        {
            var resultado = new object[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i];
            }

            for (int j = 0; j < b.Length; j++)
            {
                resultado[a.Length + j] = b[j];
            }

            return resultado;
        }
    }
}

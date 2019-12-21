using System;
using System.Collections.Generic;

namespace Soma
{
    class Gerador
    {

        public static List<int> geraListaNumero(int qtd)
        {
            List<int> lista = new List<int>();

            Random random = new Random();

            for (int i = 0; i < qtd; i++)
                lista.Add(random.Next(1,10));         

            return lista;
        }

        public static void exibeListaNumero(int qtd, List<int> lista)
        {
            Console.WriteLine("Números Gerados\n");
            for (int i = 0; i < qtd; i++)
                Console.WriteLine(lista[i]);

            Console.WriteLine("\n\n");
        }
    }
}

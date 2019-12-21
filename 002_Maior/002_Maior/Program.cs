using System;
using System.Collections.Generic;

namespace Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdNumero = 30;

            //Gera uma lista de números.
            List<int> lista = Gerador.geraListaNumero(qtdNumero);

            //Faz uma cópia da lista pois tem método que remove os elementos da mesma.
            List<int> listaAux = new List<int>(lista.ToArray());

            Console.WriteLine("Programa para retornar o maior número de uma lista de números de forma Recursiva e Iterativa - Vitor Riedo\n");

            Gerador.exibeListaNumero(qtdNumero, lista);

            Console.WriteLine("Maior Iterativo: " + Maior.maiorIterativo(lista));

            Console.WriteLine("\nMaior na Volta Recursiva Com Index: " + Maior.maiorVoltaRecursivaComIndex(0, lista));

            Console.WriteLine("\nMaior na Volta Recursiva Sem Index: " + Maior.maiorVoltaRecursivaSemIndex(listaAux));
            listaAux = new List<int>(lista.ToArray());

            Console.WriteLine("\nMaior na Ida Recursiva Com Index: " + Maior.maiorIdaRecursivaComIndex(0, 0, lista));

            Console.WriteLine("\nMaior na Ida Recursiva Sem Index: " + Maior.maiorIdaRecursivaSemIndex(0, lista.Count,lista));

            Console.WriteLine("\n\nPrecione alguma tecla para continuar!!!");
            Console.ReadKey();
        }
    }
}

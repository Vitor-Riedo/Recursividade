using System;
using System.Collections.Generic;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdNumero = 5;

            //Gera uma lista de números.
            List<int> lista = Gerador.geraListaNumero(qtdNumero);

            //Faz uma cópia da lista pois tem método que remove os elementos da mesma.
            List<int> listaAux = new List<int>(lista.ToArray());

            Console.WriteLine("Programa para somar uma lista de números de forma Recursiva e Iterativa - Vitor Riedo\n");

            Gerador.exibeListaNumero(qtdNumero, lista);

            Console.WriteLine("Soma não Recursiva: " + Soma.somaNormal(lista));

            Console.WriteLine("\nSoma na Volta Recursiva Com Index: " + Soma.somaVoltaRecursivaComIndex(0,lista));

            Console.WriteLine("\nSoma na Volta Recursiva Sem Index: " + Soma.somaVoltaRecursivaSemIndex(listaAux));
            listaAux = new List<int>(lista.ToArray()); 

            Console.WriteLine("\nSoma na Ida Recursiva Com Index: " + Soma.somaIdaRecursivaComIndex(0,0,lista));

            Console.WriteLine("\nSoma na Ida Recursiva Sem Index: " + Soma.somaIdaRecursivaSemIndex(0, lista));

            Console.WriteLine("\n\nPrecione alguma tecla para continuar!!!");
            Console.ReadKey();
        }
    }
}

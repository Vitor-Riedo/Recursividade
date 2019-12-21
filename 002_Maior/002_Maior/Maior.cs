﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Maior
{
    class Maior
    {

        public static int maiorIterativo(List<int> lista)
        {
            int maior = lista[0];

            for (int i = 1; i < lista.Count; i++)
            {
                if(maior < lista[i])
                    maior = lista[i];
            }

            return maior;
        }

        public static int somaVoltaRecursivaComIndex(int pos, List<int> lista)
        {
            if (lista.Count - 1 == pos)
                return lista[pos];

            return lista[pos] + somaVoltaRecursivaComIndex(++pos, lista); //++ antes para incrementar antes de mandar
        }

        public static int maiorVoltaRecursivaSemIndex(List<int> lista)
        {
            if (lista.Count == 1)
                return lista[0];

            int valor = lista[0];   //Salva o valor pra volta somar.
            lista.RemoveAt(0);      //Remove o primeiro valor para passar os demais.

            return valor + maiorVoltaRecursivaSemIndex(lista);
        }

        public static int maiorIdaRecursivaComIndex(int soma, int pos, List<int> lista)
        {
            soma += lista[pos++];   //Já incrementa para poder verificar no if, o problema é se mandar uma lista vazia. Dá pra fazer com o if antes.

            if (lista.Count == pos) //Não tem -1 no Count pois o pos já foi incrementado.
                return soma;

            return maiorIdaRecursivaComIndex(soma, pos, lista);
        }

        public static int maiorIdaRecursivaSemIndex(int soma, List<int> lista)
        {
            soma += lista[0];   //Soma o valor antes de mandar.

            if (lista.Count == 1) //Se a coma for depois do if é preciso fazer lista.Count == 0 
                return soma;

            //soma += lista[0];   //Soma o valor antes de mandar.
            lista.RemoveAt(0);    //Remove o primeiro valor para passar os demais.

            return maiorIdaRecursivaSemIndex(soma, lista);
        }
    }
}

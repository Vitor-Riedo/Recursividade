using System;
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

        public static int maiorVoltaRecursivaComIndex(int pos, List<int> lista)
        {
            if (lista.Count - 1 == pos)//Retorna quando for o último
                return lista[pos];

            int retorno = maiorVoltaRecursivaComIndex(pos + 1, lista);    //Guarda para comparação

            return (lista[pos] > retorno) ? lista[pos] : retorno;       //Condição ternária para retornar. (retorna o que está antes do ':' se for verdade a condição, se não passa a segunda parte)
        }

        public static int maiorVoltaRecursivaSemIndex(List<int> lista)
        {
            if (lista.Count == 1)
                return lista[0];

            int valor = lista[0];
            lista.RemoveAt(0);      //Remove o primeiro valor para passar os demais.

            int retorno = maiorVoltaRecursivaSemIndex(lista);

            return (valor > retorno) ? valor : retorno;
        }

        public static int maiorIdaRecursivaComIndex(int maior, int pos, List<int> lista)
        {
            if (lista.Count == pos)//Retorna quando for o último
                return maior;

            if (pos == 0)
                maior = lista[pos++];

            if (maior < lista[pos])
                maior = lista[pos];

            return maiorIdaRecursivaComIndex(maior, ++pos, lista); 
        }

        public static int maiorIdaRecursivaSemIndex(int maior, int tamLista, List<int> lista)
        {
            if (lista.Count == 0)//Retorna quando for o último
                return maior;

            if (lista.Count == tamLista)
            {
                maior = lista[0];
                lista.RemoveAt(0); // Remove o que acabou de salvar
            }

            if (maior < lista[0])
                maior = lista[0];

            lista.RemoveAt(0); // Remove o que acabou de salvar

            return maiorIdaRecursivaSemIndex(maior, tamLista, lista);
        }
    }
}

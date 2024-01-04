using System;
using System.Collections.Generic;

using EntendendoAlgoritmos.Cap1;
using EntendendoAlgoritmos.Cap2;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Capítulo 1 - Introduction to algorithms
                {"Pesquisa Binária | Binary Search", PesquisaBinaria.Executar},
                                
                //Capítulo 2 - Selection sort
                {"Selection sort", Cap2_SelectionSort.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}
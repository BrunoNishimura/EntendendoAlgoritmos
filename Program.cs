﻿using System;
using System.Collections.Generic;

using EntendendoAlgoritmos.Cap1;
using EntendendoAlgoritmos.Cap2;
using EntendendoAlgoritmos.Cap3;

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
                {"Selection Sort", Cap2_SelectionSort.Executar},
                {"Double Selection Sort", DoubleSelectionSort.Executar},

                //Capítulo 2 - Selection sort
                {"Countdown", Cap3_01_Countdown.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}
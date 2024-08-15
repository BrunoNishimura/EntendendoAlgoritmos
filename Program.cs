using System;
using System.Collections.Generic;

using EntendendoAlgoritmos.Cap1;
using EntendendoAlgoritmos.Cap2;
using EntendendoAlgoritmos.Cap3;
using EntendendoAlgoritmos.Cap4;
using EntendendoAlgoritmos.Codewars.kyu_6;

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

                //Capítulo 3 - Recursion
                {"Countdown", Cap3_01_Countdown.Executar},
                {"Greet", Cap3_02_Greet.Executar},
                {"Factorial", Cap3_03_Factorial.Executar},

                //Capítulo 4 - Quicksort
                {"Loop Sum", Cap4_01_Loop_Sum.Executar},
                {"Recursive Sum", Cap4_02_Recursive_Sum.Executar},
                {"Recursive Count", Cap4_03_Recursive_Count.Executar},
                {"Recursive Max", Cap4_04_Recursive_Max.Executar},

                //CodeWars - 6 Kyu
                {"Conversor de Numeros Romanos", RomanConverter.Executar },
                {"Cada digito elevado ao quadrado", SquareDigits.Executar } //Eficiencia do codigo
            })
            {

            };
            central.SelecionarEExecutar();
        }
    }
}
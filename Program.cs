using System;
using System.Collections.Generic;

using EntendendoAlgoritmos.Cap1;
using EntendendoAlgoritmos.Cap2;
using EntendendoAlgoritmos.Cap3;
using EntendendoAlgoritmos.Cap4;
using EntendendoAlgoritmos.Codewars.kyu_5;
using EntendendoAlgoritmos.Codewars.kyu_6;
using EntendendoAlgoritmos.Codewars.kyu_hard;

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
                {"Cada digito elevado ao quadrado", SquareDigits.Executar }, //Eficiencia do codigo
                {"Ordernar palavras por numeros", OrderWordsByNumber.Executar },
                {"Ferias acessiveis", AffordableVacation.Executar }, //Bastante desafiador, performance como criterio de aceite
                
                //Codewars - 5 kyu
                {"Seguindos os Zeros, após resolver o Fatorial", FatorialAndTrailingZeros.Executar }, //Bastante desafiador, performance como criterio de aceite


                //Prova
                {"Inverso da Sequencia", CPNU_RevertSequence.Executar }, //Desafio da Prova do CPNU
            });
            central.SelecionarEExecutar();
        }
    }
}
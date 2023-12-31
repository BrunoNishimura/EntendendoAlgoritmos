﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap2
{
    internal class Cap2_SelectionSort
    {
        private static int[] SelectionSort(List<int> arr)
        {
            var newArr = new int[arr.Count];
            for (int i = 0; i < newArr.Length; i++)
            {
                var smallest = FindSmallest(arr);
                newArr[i] = arr[smallest];
                arr.RemoveAt(smallest);
            }
            return newArr;
        }

        private static int FindSmallest(List<int> arr)
        {
            var smallest = arr[0];
            var smallestIndex = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        private static void SelectionSort(int[] unorderedArray)
        {
            for (var i = 0; i < unorderedArray.Length; i++)
            {
                var smallestIndex = i;

                for (var remainingIndex = i + 1; remainingIndex < unorderedArray.Length; remainingIndex++)
                {
                    if (unorderedArray[remainingIndex] < unorderedArray[smallestIndex])
                    {
                        smallestIndex = remainingIndex;
                    }
                }

                // Troca os elementos
                int temp = unorderedArray[i];
                unorderedArray[i] = unorderedArray[smallestIndex];
                unorderedArray[smallestIndex] = temp;
            }
        }
        public static void Executar()
        {
            //Invocando o método - SelectionSort(List<int> arr)
            var arr = new List<int> { 5, 3, 6, 2, 10 };
            Console.WriteLine(string.Join(", ", SelectionSort(arr)));


            //Invocando o método - SelectionSort(int[] unorderedArray)
            int[] array = { 5, 3, 6, 2, 10 };

            Console.WriteLine("Array antes da ordenação: " + string.Join(", ", array));

            // Chamando o método de ordenação
            SelectionSort(array);

            Console.WriteLine("Array após a ordenação: " + string.Join(", ", array));
        }
    }
}

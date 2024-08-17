using EntendendoAlgoritmos.Codewars.kyu_6;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars.kyu_hard
{
    internal class AffordableVacation
    {
        public static string FindMinCost_LowPerformance(int money, int days, int[] cost)
        {
            int n = cost.Length;
            int minCost = int.MaxValue;
            int currentWindowSum = 0;

            // Calculate the sum of the initial window
            for (int i = 0; i < days; i++)
            {
                currentWindowSum += cost[i];
            }

            // Initialize minCost with the first window sum
            minCost = Math.Min(minCost, currentWindowSum);

            // Slide the window across the array
            for (int i = days; i < n; i++)
            {
                currentWindowSum = currentWindowSum - cost[i - days] + cost[i];
                minCost = Math.Min(minCost, currentWindowSum);
            }

            // If the minimum cost for the duration is within the budget
            if (minCost <= money)
            {
                return $"money: {minCost}";
            }

            // Finding the maximum number of days the student can afford consecutively
            for (int d = days - 1; d > 0; d--)
            {
                currentWindowSum = 0;

                // Calculate the sum of the initial window of size d
                for (int i = 0; i < d; i++)
                {
                    currentWindowSum += cost[i];
                }

                // If the initial window of size d is affordable
                if (currentWindowSum <= money)
                {
                    return $"days: {d}";
                }

                // Slide the window of size d
                for (int i = d; i < n; i++)
                {
                    currentWindowSum = currentWindowSum - cost[i - d] + cost[i];
                    if (currentWindowSum <= money)
                    {
                        return $"days: {d}";
                    }
                }
            }

            // If even 1 day cannot be afforded
            return "days: 0";
        }

        public static string FindMinCost_HighPerformance(int money, int days, int[] cost)
        {
            int n = cost.Length;

            int minCost = int.MaxValue;
            int windowSum = 0;
            for (int i = 0; i < n; i++)
            {
                windowSum += cost[i];
                if (i >= days - 1)
                {
                    minCost = Math.Min(minCost, windowSum);
                    windowSum -= cost[i - days + 1];
                }
            }

            if (minCost <= money)
            {
                return $"money: {minCost}";
            }

            int maxDays = 0;
            int start = 0;
            windowSum = 0;
            for (int end = 0; end < n; end++)
            {
                windowSum += cost[end];
                while (windowSum > money && start <= end)
                {
                    windowSum -= cost[start];
                    start++;
                }
                if (end - start + 1 > maxDays)
                {
                    maxDays = end - start + 1;
                }
            }

            return $"days: {maxDays}";
        }

        public static void Executar()
        {

            #region Variaveis do teste
            Random random = new Random();

            // Defina o tamanho do array de custos para algo bem grande, por exemplo, 1.000.000
            int n = 1000000;//1000000
            int[] cost = new int[n];

            // Preencha o array com valores aleatórios entre 1 e 100
            for (int i = 0; i < n; i++)
            {
                cost[i] = random.Next(1, 101);
            }

            // Defina valores de dinheiro e dias aleatórios
            int money = random.Next(1, 1000001);
            int days = random.Next(1, 100001);
            #endregion


            //int money = 10;
            //int days = 1;
            //int[] cost = new int[] { 5 };
            //string expected = "money: 5";

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string result = AffordableVacation.FindMinCost_LowPerformance(money, days, cost);

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Tempo com FindMinCost_LowPerformance: {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Stop();


            stopwatch.Reset();

            stopwatch.Start();
            string result2 = AffordableVacation.FindMinCost_HighPerformance(money, days, cost);
            Console.WriteLine($"Result: {result2}");
            Console.WriteLine($"Tempo com FindMinCost_HighPerformance: {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Stop();
            //Console.WriteLine($"expected={expected}");





        }

    }
}
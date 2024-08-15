using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars.kyu_6
{
    internal class SquareDigits
    {
        public static int SquareDigitsWithLinq(int n)
        {
            string nStr = n.ToString();

            var squaredDigits = nStr.Select(digit =>
            {
                int num = int.Parse(digit.ToString());
                return (num * num).ToString();
            });

            string resultStr = string.Concat(squaredDigits);
            int result = int.Parse(resultStr);

            return result;
        }

        public static int SquareDigitsWithoutLinq(int n)
        {
            string nStr = n.ToString();
            StringBuilder resultStr = new StringBuilder();

            foreach (char digit in nStr)
            {
                int num = int.Parse(digit.ToString());
                resultStr.Append((num * num).ToString());
            }

            int result = int.Parse(resultStr.ToString());

            return result;
        }

        public static void Executar()
        {
            int testValue = 8991;
            int iterations = 1000000;

            // Medindo a eficiência da abordagem com LINQ
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < iterations; i++)
            {
                SquareDigits.SquareDigitsWithLinq(testValue);
            }

            stopwatch.Stop();
            Console.WriteLine($"Tempo com LINQ: {stopwatch.ElapsedMilliseconds} ms");

            // Medindo a eficiência da abordagem sem LINQ
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < iterations; i++)
            {
                SquareDigits.SquareDigitsWithoutLinq(testValue);
            }

            stopwatch.Stop();
            Console.WriteLine($"Tempo sem LINQ: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}

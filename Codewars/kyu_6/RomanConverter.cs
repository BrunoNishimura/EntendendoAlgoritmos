using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars.kyu_6
{
    internal class RomanConverter
    {
        private static string IntToRoman(int num) //O parâmetro num é a entrada que o método usa para realizar a conversão para seu equivalente em numerais romanos.
        {
            // Define the mapping of Roman numerals to their corresponding integer values
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            // Convert each digit into its Roman numeral equivalent
            string roman = thousands[num / 1000] +
                           hundreds[(num % 1000) / 100] +
                           tens[(num % 100) / 10] +
                           ones[num % 10];

            Console.WriteLine("num:" + num);
            Console.WriteLine("thousands[num / 1000]:" + num / 1000 + " " + thousands[num / 1000]); //Passo 1
            Console.WriteLine("hundreds[(num % 1000) / 100]: " + (num % 1000) / 100 + " " + hundreds[(num % 1000) / 100]); //Passo 1
            Console.WriteLine("tens[(num % 100) / 10]: " + (num % 100) / 10 + " " + tens[(num % 100) / 10]); //Passo 1
            Console.WriteLine("ones[num % 10]: " + num % 10 + " " + ones[num % 10]); //Passo 1

            return roman;
        }


        public static string IntToRomanII(int n) //Usando Dicionário
        {
            var romeDict = new Dictionary<int, string>()
            {
                [1000] = "M",
                [900] = "CM",
                [500] = "D",
                [400] = "CD",
                [100] = "C",
                [90] = "XC",
                [50] = "L",
                [40] = "XL",
                [10] = "X",
                [9] = "IX",
                [5] = "V",
                [4] = "IV",
                [1] = "I"
            };

            var number = new StringBuilder();
            foreach (var romeNum in romeDict)
            {
                while (romeNum.Key <= n)
                {
                    number.Append(romeNum.Value);
                    n -= romeNum.Key;
                }
            }

            return number.ToString();
        }


        public static void Executar()
        {
            Console.WriteLine(IntToRoman(1000)); //num = 1995; => MCMXCV
            Console.WriteLine(IntToRomanII(1000)); //Usando Dicionario
        }
    }
}

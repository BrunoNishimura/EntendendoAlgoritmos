using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars._6kyu
{
    internal class RomanConverter
    {
        private static string IntToRoman(int num)
        {
            // Define the mapping of Roman numerals to their corresponding integer values
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            // Convert each digit into its Roman numeral equivalent
            string roman = thousands[num / 1000] +
                           hundreds[(num % 1000) / 100] +
                           tens[(num % 100) / 10] +
                           ones[num % 10];

            return roman;
        }

        public static void Executar()
        {
            Console.WriteLine(IntToRoman(1995));
        }
    }
}

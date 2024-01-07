using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap3
{
    internal class Cap3_01_Countdown
    {
        private static void Countdown(int i)
        {
            Console.WriteLine(i);

            // base case
            if (i <= 0) return;

            // recursive case
            Countdown(i - 1);
        }
        public static void Executar()
        {
            Countdown(5);
        }
    }
}

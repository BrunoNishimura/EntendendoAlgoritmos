using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap3
{
    internal class Cap3_03_Factorial
    {
        private static int Fact(int x)
        {
            if (x <= 1) return 1;

            return x * Fact(x - 1);
        }

        public static void Executar()
        {
            Console.WriteLine(Fact(5));
        }
    }
}

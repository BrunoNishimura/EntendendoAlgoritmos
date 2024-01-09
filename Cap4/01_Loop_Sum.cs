using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap4
{
    internal class Cap4_01_Loop_Sum
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

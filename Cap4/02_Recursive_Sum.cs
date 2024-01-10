using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap4
{
    internal class Cap4_02_Recursive_Sum
    {
        private static int Sum(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return list.Take(1).First() + Sum(list.Skip(1));
        }
        public static void Executar()
        {
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
        }
    }
}

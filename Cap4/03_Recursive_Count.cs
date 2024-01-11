using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap4
{
    internal class Cap4_03_Recursive_Count
    {
        private static int Count(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return 1 + Count(list.Skip(1));
        }
        public static void Executar()
        {
            Console.WriteLine(Count(new[] { 1, 2, 3, 4 }));
        }
    }
}

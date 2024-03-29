﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap4
{
    internal class Cap4_04_Recursive_Max
    {
        private static int Max(IEnumerable<int> list)
        {
            if (!list.Any()) throw new ArgumentException(nameof(list));
            if (list.Count() == 1) return list.First();
            if (list.Count() == 2) return list.First() > list.Skip(1).Take(1).First() ? list.First() : list.Skip(1).Take(1).First();
            var sub_max = Max(list.Skip(1));
            return list.First() > sub_max ? list.First() : sub_max;
        }
        public static void Executar()
        {
            Console.WriteLine(Max(new[] { 1, 3, 2, 5, 9, 8 }));
        }
    }
}

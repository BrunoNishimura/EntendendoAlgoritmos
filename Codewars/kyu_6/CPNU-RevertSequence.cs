using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars.kyu_6
{
    internal class CPNU_RevertSequence
    {
        public static int InverterValores(int number)
        {
            int valorInvertido = number + 1;

            return valorInvertido;
        }

        public static void Executar()
        {
            int teste = 1234;

            Console.WriteLine(InverterValores(teste));
        }
    }
}

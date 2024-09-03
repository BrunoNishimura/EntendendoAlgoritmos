using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars.kyu_5
{
    internal class FatorialAndTrailingZeros
    {


        static long Fatorial(int n)
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++) // A multiplicação por 1 é redundante, por isto começamos pelo 2 para otimizar o código!
            {
                //resultado = resultado * i;
                resultado *= i;
            }
            return resultado;
        }

        public static void Executar()
        {
            int teste = 3;
            //Console.WriteLine(TrailingZeros(teste));
            Console.WriteLine(Fatorial(teste));
        }
    }
}

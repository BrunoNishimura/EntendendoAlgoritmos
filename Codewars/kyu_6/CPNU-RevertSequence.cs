using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars.kyu_6
{
    internal class CPNU_RevertSequence
    {

        public static int InverterDigitos(int numero)
        {
            int resultado = 0;

            while (numero > 0)
            {
                int digito = numero % 10; // Obtém o último dígito
                resultado = resultado * 10 + digito; // Adiciona o dígito ao resultado
                numero /= 10; // Remove o último dígito do número
            }

            return resultado;
        }

        public static void Executar()
        {
            int teste1 = 1234;
            int teste2 = 1000;
            int teste3 = 4;

            Console.WriteLine(InverterDigitos(teste1));
            Console.WriteLine(InverterDigitos(teste2));
            Console.WriteLine(InverterDigitos(teste3));
        }
    }
}

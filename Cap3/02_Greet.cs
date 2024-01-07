using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap3
{
    internal class Cap3_02_Greet
    {
        private static void Greet(string name)
        {
            Console.WriteLine($"hello, {name}!");
            Greet2(name);
            Console.WriteLine("getting ready to say bye...");
            Bye();
        }

        private static void Greet2(string name)
        {
            Console.WriteLine($"how are you, {name}?");
        }

        private static void Bye()
        {
            Console.WriteLine("ok bye!");
        }
        public static void Executar()
        {
            Greet("adit");
        }
    }
}

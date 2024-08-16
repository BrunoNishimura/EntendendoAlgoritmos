using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Codewars.kyu_6
{
    internal class OrderWordsByNumber
    {

        //"is9 is8 is7 is6 is5 is4 is3 is2 is1"

        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                //return string.Empty; //Output: ""
                return "string vazia";
            }

            // Split the input string into an array of words
            var wordsArray = words.Split(' ');

            // Order the words based on the number within each word
            var sortedWords = wordsArray.OrderBy(word => word.First(char.IsDigit)).ToArray();

            // Join the sorted words back into a single string
            return string.Join(" ", sortedWords);
        }

        public static void Executar() {
            string example1 = "is2 Thi1s T4est 3a";
            string example2 = "4of Fo1r pe6ople g3ood th5e the2";
            string example3 = "";
            string example4 = "9nove 8oito 7sete 6seis 5cinco 4quatro 3tres 2dois 1um";
            string example5 = "91nove 82oito 73sete 64seis 55cinco 46quatro 37tres 28dois 19um";

            Console.WriteLine(Order(example1)); // Output: "Thi1s is2 3a T4est"
            Console.WriteLine(Order(example2)); // Output: "Fo1r the2 g3ood 4of th5e pe6ople"
            Console.WriteLine(Order(example3)); // Output: "string vazia"
            Console.WriteLine(Order(example4)); // Output: "1um 2dois 3tres 4quatro 5c5inco 6seis 7sete 8oito 9nove"
            Console.WriteLine(Order(example5)); // Output: "19um 28dois 37tres 46quatro 55cinco 64seis 73sete 82oito 91nove"
        }
    }
}
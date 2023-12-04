using System;
using System.Collections.Generic;

using EntendendoAlgoritmos.Cap1;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Capítulo 1
                {"Pesquisa Binária | Binary Search", PesquisaBinaria.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}
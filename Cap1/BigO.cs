using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Cap1
{
    internal class BigO
    {
        /*  Notação Big O
             *      - A notação Big O é uma notação especial que diz o quão rápido é um algoritmo.
             *          Não basta saber somente quanto tempo um algoritmo leva para ser executado - É necessário saber também se o tempo de execução aumenta conforme a lista aumenta.
             * 
             *      - A notação Big O permite que você compare o número de operações. Isso fornece o número de operações que um algoritmo realiza.
             *      - A notação Big O estabelece o tempo de execuçào para a pior hipótese.
             *          Exemplo: Você sabe, com certeza, que a pesquisa simples nuca terá o tempo de execução mais lento do que o O(n).
             *      
             *  Exemplos comuns de tempo de execução Big O
             *      Aqui temos 5 tempos de execução Big O que você encontrará bastante, ordenados do mais rápido para o mais lento.
             *          - O(Log n):     Conhecido como tempo logarítmico.                           Exemplo: Pesquisa Binária;
             *          - O(n):         Conhecido como tempo linear.                                Exemplo: Pesquisa Simples;
             *          - O(n * Log n): Um algoritmo rápido de ordenação.                           Exemplo: Ordenação Quicksort (Cap. 4);
             *          - O(n^2):       Um algoritmo lento de ordenação.                            Exemplo: Ordenação por Seleção (Cap. 2);
             *          - O(n!):        Um algoritmo bastante lento.                                Exemplo: Caixeiro-viajante
        */

        /*  Principais Pontos:
             *      - A rapidez de um algoritmo não é medida em segundos, mas pelo crescimento do número de operações;
             *      - Em vez disso, discutimos sobre o quão rapidamente o tempo de execução de um algoritmo aumenta conforme o número de elementos aumenta.
             *      - O tempo de execução em algoritmos é expresso na notação Big O.
             *      - O(Log n) é mais rápido do que o O(n), e o O(log n) fica ainda mais rápido conforme a lista aumenta.
        */

        /*  Exercicíos:
            *   Fornece o tempo de execução para cada um dos casos a seguir em termos da notação Big O.
            *       
            *   1.3 Você tem um nome e deseja encontrar o número de telefone para esse nome em uma agenda telefônica.
            *       Resposta: O(Log n);
            *   1.4 Você tem um número de telefone e deseja encontrar o dono dele em uma agenda telefônica. (Dica: Deve procurar pela agenda inteira!)
            *       Resposta: O(n);
            *   1.5 Você quer ler o número de cada pessoa da agenda telefônica.
            *       Resposta: O(n);
            *   1.6 Você quer ler os números apenas dos nomes que começam com A.(Isso é complicado! Esse algoritmo envolve conceito que são abordados mais profundamente no Capítulo 4. Leia a resposta - você ficará surpreso!)
            *       Resposta: O(n). Você pode pensar: "Só estou fazendo isso para 1 dentre 26 caracteres, portanto o tempo de execução deve ser O(n/26)". Uma regra simples é a de ignorar números que são somados, subtraídos, multiplicados ou divididos.
            *                 Nenhum desses são tempo de execução Big O:
            *                   - O(n + 26);
            *                   - O(n - 26);
            *                   - O(n * 26);
            *                   - O(n / 26);
            *                 
            *                 Eles são todos o mesmo que O(n).
            *                 Por quê? Se você está com dúvidas, vá para "Notação Big O revisada", no Capítulo 4, leia a parte sobre constantes na notação Big O (Uma constante é apenas um número; 26 era a constante em questão).
        */



    }
}

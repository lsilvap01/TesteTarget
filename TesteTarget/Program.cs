// See https://aka.ms/new-console-template for more information
/* Questão 2:
Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
 */

bool isFibonacci(int n)
{
    if (n < 0) return false;
    if (n <= 3) return true;

    var _fn = 2;
    var fn = 3;
    while (fn < n)
    {
        fn = _fn + fn;
        _fn = fn - _fn;
    }

    return fn == n;
}

//Número a ser testado
int n = 55;
var nIsFibonacci = isFibonacci(n);

if (nIsFibonacci) 
    Console.WriteLine($"O número {n} faz parte da sequência de Fibonacci!");
else 
    Console.WriteLine($"O número {n} NÃO faz parte da sequência de Fibonacci :(");

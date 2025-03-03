// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Xml.Serialization;
using TesteTarget.Model;

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


/* Questão 3:
Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
 */

void statsFaturamento(Faturamento[] faturamentos)
{
    var valoresFaturamento = faturamentos.Select(f => f.valor).ToArray();
    var menorValorFat = valoresFaturamento.Min();
    var maiorValorFat = valoresFaturamento.Max();
    var mediaValorFat = valoresFaturamento.Average();
    var qtdDiasComFatAcimaDaMedia = valoresFaturamento.Where(v => v > mediaValorFat).Count();

    Console.WriteLine($"Menor valor de faturamento ocorrido: R$ {menorValorFat}");
    Console.WriteLine($"Maior valor de faturamento ocorrido: R$ {maiorValorFat}");
    Console.WriteLine($"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: {qtdDiasComFatAcimaDaMedia}");
}

// Lê arquivo json com valores de faturamento
string fonteDadosJson = "Dados/dados.json";
string dadosJson = File.ReadAllText(fonteDadosJson);
Faturamento[] faturamentos = JsonSerializer.Deserialize<Faturamento[]>(dadosJson)!;

// Exibe estatísticas do faturamento JSON
statsFaturamento(faturamentos);


/* Questão 4:
 Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado: 
• SP – R$67.836,43 
• RJ – R$36.678,66 
• MG – R$29.229,88 
• ES – R$27.165,48 
• Outros – R$19.849,53 
Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
 */

void statsFaturamentoEstado(Dictionary<string, float> faturamentoUFs)
{
    var faturamentoTotal = faturamentoUFs.Values.Sum();
    Console.WriteLine($"Percentual de representação que cada estado teve dentro do valor total mensal da distribuidora (faturamento total: {faturamentoTotal.ToString("c2")})");
    foreach(var faturamento in  faturamentoUFs)
    {
        var uf = faturamento.Key;
        var fat = faturamento.Value;
        var percentual = (fat / faturamentoTotal) * 100;
        Console.WriteLine($"{uf} - {fat.ToString("c2")} ({percentual} % do faturamento total)");
    }
}

var faturamentoUFs =  new Dictionary<string, float> {
    ["SP"] = 67836.43f,
    ["RJ"] = 36678.66f, 
    ["MG"] = 29229.88f,
    ["ES"] = 27165.48f, 
    ["Outros"] = 19849.53f
};

// Exibe estatísticas do faturamento por Estado
statsFaturamentoEstado(faturamentoUFs);
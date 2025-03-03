# Testes técnicos - Desenvolvedor de Sistemas (Target Sistemas)
O código deste repositório, programado para solucionar as questão de 2 a 5 do teste técnico, foram desenvolvidos na linguagem C# em uma aplicação console da plataforma .Net.

## Teste 1
### Questão
Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0; Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } Imprimir(SOMA); Ao final do processamento, qual será o valor da variável SOMA?

### Solução
Ao final do processamento, o valor da variável SOMA será igual a 91

### Teste 2
#### Questão
Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
### Resultado (testando o número 55)
O número 55 faz parte da sequência de Fibonacci!

## Teste 3 
### Questão
Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
- O menor valor de faturamento ocorrido em um dia do mês;
- O maior valor de faturamento ocorrido em um dia do mês;
- Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
  IMPORTANTE: 
    a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal; 
    b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média
### Resultado (utilizando fonte de dados JSON)
Menor valor de faturamento ocorrido: R$ 373,7838

Maior valor de faturamento ocorrido: R$ 48924,246

Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: 10

## Teste 4
### Questão
 Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado: 
 - SP – R$67.836,43
 - RJ – R$36.678,66
 - MG – R$29.229,88
 - ES – R$27.165,48
 - Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
### Resultado

Percentual de representação que cada estado teve dentro do valor total mensal da distribuidora (faturamento total: R$ 180.759,98)

SP - R$ 67.836,43 (37,528454 % do faturamento total)

RJ - R$ 36.678,66 (20,29136 % do faturamento total)

MG - R$ 29.229,88 (16,170547 % do faturamento total)

ES - R$ 27.165,48 (15,0284815 % do faturamento total)

Outros - R$ 19.849,53 (10,981153 % do faturamento total)

## Teste 5
### Questão
Escreva um programa que inverta os caracteres de um string. 

IMPORTANTE: 

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código; 

b) Evite usar funções prontas, como, por exemplo, reverse;

### Resultado (testando a string "TESTE ABC")

String original: TESTE ABC

String invertida: CBA ETSET

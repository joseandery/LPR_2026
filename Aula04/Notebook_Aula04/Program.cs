using System;
using System.Runtime.ConstrainedExecution;
// AULA 04 - ESTRUTURAS DE SELEÇÃO

// Estrutura de seleção = verificação de expressão lógica
int idade = 18;

System.Console.WriteLine(idade>18);

// SELEÇÃO SIMPLES (IF)


if (idade > 18)
{
    Console.WriteLine("Maior de idade");
}

// SELEÇÃO COMPOSTA (IF-ELSE)

if(idade > 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Um bebê");
}

// SELEÇÃO ENCADEADA 
    // SELEÇÃO ENCADEADA HOMOGENEA -> MESMA VARIÁVEL (EX: IDADE)
        // SELEÇÃO ENCADEADA HOMOGENEA CONTÍNUA ->> VARIÁVEL ASSUME INFINITOS VALORES: 
        // USO: IF-ELSE

int temperatura = 30;

if (temperatura < 0)
{
    System.Console.WriteLine("Frio demais");
}
else if (temperatura >= 0 && temperatura < 10)
{
    System.Console.WriteLine("Frio de leve");
}
else if (temperatura > 35)
{
    if 
    System.Console.WriteLine("Calorzão!");
}
else //CONDIÇÃO PADRÃO -> PEGA TODOS VALORES FORA DAS CONDIÇÕES MAPEADAS
{
    System.Console.WriteLine("Tá tranquilo");
}

        // SELEÇÃO ENCADEADA HOMOGENEA DISCRETA ->> VARIÁVEL ASSUME VALORES MAPEADOS!
        // USO SWITCH
        // SWITCH COM STRING SÓ NO C#! NO C++ SWITCH SÓ COM INT!

int diaDaSemana = 7; //1 = segunda

switch(diaDaSemana)
{
    case 1:
        System.Console.WriteLine("Hoje é segunda!");
        break;
    case 2:
        System.Console.WriteLine("Hoje é terça!");
        break;
    case 3:
        System.Console.WriteLine("Hoje é quarta!");
        break;
    case 4:
        System.Console.WriteLine("Hoje é quinta!");
        break;
    case 5:
        System.Console.WriteLine("Hoje é sexta!");
        break;
    default:   System.Console.WriteLine("dia inválido"); break;
}

// SELEÇÃO ENCADEADA HETEROGENEA -> VARIÁVEIS DISTINTAS (EX: IDADE E SIGNO)

int umidade = 80;
int pressao = 1000;

if (temperatura > 10) System.Console.WriteLine($"A temperatura é {temperatura}");
else if (umidade > 70) System.Console.WriteLine($"A umidade é {umidade}");
else if (umidade < 70 || temperatura <10 && pressao > 600) System.Console.WriteLine("entrou nessa condição");

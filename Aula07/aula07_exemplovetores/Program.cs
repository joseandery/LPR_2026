// Aula de vetores

// criar um vetor

using System.Runtime.CompilerServices;

int idadeIuri = 17;
int idadeMarcos = 18;
int idadeMaria = 0;

// criar um vetor para armazenar as idades'

int[] idades = new int[4]; // vetor de inteiros com 4 posições

// atribuir valores ao vetor

idades[0] = idadeIuri;
idades[1] = idadeMarcos;
idades[2] = idadeMaria;
idades[3] = 20;

// acessar os valores do vetor

System.Console.WriteLine("Acesso de valor unitário do vetor: ");

Console.WriteLine("Idade de Iuri: " + idades[0]);

// percorrer o vetor com um laço de repetição

System.Console.WriteLine("Percorrer o vetor com um laço de repetição: ");
for (int i = 0; i < idades.Length; i++)
{
    Console.WriteLine("Idade na posição " + i + ": " + idades[i]);
}
// modificar um valor do vetor

System.Console.WriteLine("Modificar um valor do vetor: ");
idades[0] = 25;
Console.WriteLine("Idade de Iuri após modificação: " + idades[0]);

// percorrer o vetor com um foreach

System.Console.WriteLine("Percorrer o vetor com um foreach: ");
foreach (var elemento in idades)
{
    Console.WriteLine("Idade: " + elemento);
}

// métodos da classe Array

System.Console.WriteLine("Métodos da classe Array: ");

// ordenar o vetor
Array.Sort(idades);
Console.WriteLine("Vetor ordenado: ");
foreach (var elemento in idades) Console.WriteLine("Idade: " + elemento);

// reverter o vetor
Array.Reverse(idades);
Console.WriteLine("Vetor revertido: ");
foreach (var elemento in idades) Console.WriteLine("Idade: " + elemento);

// busca do indice de um elemento
int indice = Array.IndexOf(idades, 18);
Console.WriteLine("Índice do elemento 18: " + indice);
Console.WriteLine("Índice do elemento 5: " + Array.IndexOf(idades, 5) );

// busca de elemento no vetor com find
int elementoEncontrado = Array.Find(idades, elemento => elemento == 20);
Console.WriteLine("Elemento encontrado com Find: " + elementoEncontrado);

// busca de elemento no vetor com findAll
int[] elementosEncontrados = Array.FindAll(idades, elemento => elemento > 18);
Console.WriteLine("Elementos encontrados com FindAll (maiores que 18): ");
foreach (var elemento in elementosEncontrados) Console.WriteLine("Idade: " + elemento);
// busca de elemento no vetor com Contains
bool elementoExiste = Array.Exists(idades, elemento => elemento == 20);
Console.WriteLine("Elemento 20 existe no vetor: " + elementoExiste);

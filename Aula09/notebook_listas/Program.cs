// AULA 09 - LISTAS


// Criação de uma nova lista
List<int> numeros = new List<int>();

//Adição de novos elementos

numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);

//Varredura da lista

foreach(var elemento in numeros)
{
    System.Console.WriteLine(elemento);
}

//Métodos:
    // Quantidade de elementos

System.Console.WriteLine("Quantidade de elementos da lista: " + numeros.Count);

    // Remoção de elementos

numeros.Remove(2);
System.Console.WriteLine("Removendo número 2");
foreach(var elemento in numeros)
{
    System.Console.WriteLine(elemento);
}
System.Console.WriteLine("Quantidade de elementos da lista: " + numeros.Count);

// remover elemento em endereço específio

numeros.RemoveAt(3);
System.Console.WriteLine("Removendo número da posição 3");
foreach(var elemento in numeros)
{
    System.Console.WriteLine(elemento);
}
System.Console.WriteLine("Quantidade de elementos da lista: " + numeros.Count);

// verificação de existencia de elemento

System.Console.WriteLine("Verificando se a lista contém o número 2");

System.Console.WriteLine(numeros.Contains(2));


// adicionando elemento em posição específica

numeros.Insert(2,20);
System.Console.WriteLine("Adicionando elemento 20 na terceira posição");
foreach(var elemento in numeros)
{
    System.Console.WriteLine(elemento);
}
System.Console.WriteLine("Quantidade de elementos da lista: " + numeros.Count);


int[,] matriz = new int[3, 4];

// linha 0 = idade
// linha 1 = peso
// linha 2 = altura

// coluna 0 = Hulk
matriz[0, 0] = 50;
matriz[1, 0] = 300;
matriz[2, 0] = 2;

// coluna 1 = Homem Aranha
matriz[0, 1] = 18;
matriz[1, 1] = 75;
matriz[2, 1] = 2;

// coluna 2 = Capitão América
matriz[0, 2] = 100;
matriz[1, 2] = 100;
matriz[2, 2] = 2; 

// coluna 3 = Thanos
matriz[0, 3] = 1000;
matriz[1, 3] = 500;
matriz[2, 3] = 3;

// acessar o peso do Homem Aranha
Console.WriteLine($"O peso do Homem Aranha é: {matriz[1, 1]} kg");

// modificar o peso do Homem Aranha
matriz[1, 1] = 80;
Console.WriteLine($"O peso do Homem Aranha é: {matriz[1, 1]} kg");

// iteração de elementos com for
Console.WriteLine("\nIteração com for:");
for (int l = 0; l < matriz.GetLength(0); l++)
{
    for (int c = 0; c < matriz.GetLength(1); c++)
    {
        Console.Write($"{matriz[l, c]} \t");
    }
    Console.WriteLine();
}

// iteração de elementos com foreach
Console.WriteLine("\nIteração com foreach:");

foreach (int valor in matriz)
{
    Console.Write($"{valor} \t");
}
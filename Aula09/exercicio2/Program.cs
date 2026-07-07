// DEFININDO TAMANHO DA LISTA DE NOMES
Console.WriteLine("Digite a quantidade de nomes da lista: ");
int qtd = int.Parse(Console.ReadLine()??"0");

// PREENCHENDO LISTA
List<string> nomes = new List<string>();
for (int i = 0; i < qtd; i++)
{
    Console.WriteLine("Digite o nome: ");
    string nome = Console.ReadLine()??"";
    nomes.Add(nome);
}

// ENCONTRANDO MAIOR NOME
int maiornome = 0;
foreach (string nome in nomes)
{
    if (nome.Length > maiornome)
    {
        maiornome = nome.Length;
    }
}

// MOSTRANDO NOMES
while (nomes is not null)
{   
    for(int i = 1; i <=maiornome; i++) //tamanho
    {
        int aux = 0;
        while (aux < nomes.Count) // nomes
        {
            if (nomes[aux].Length == i)
            {
                Console.Write(nomes[aux]); 
                nomes.RemoveAt(aux);
                aux = nomes.Count; // para sair do while
            }
            else
            {
                aux++;
            }
        }
    }
    Console.WriteLine();
}



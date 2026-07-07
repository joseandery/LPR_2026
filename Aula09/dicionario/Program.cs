Dictionary<string,int> notas = new Dictionary<string, int>();

notas.Add("Ana",10);
notas.Add("Carlos",5);

foreach(var elemento in notas)
{
    System.Console.WriteLine(elemento.Key, elemento.Value);
}

// verificando a existencia da chave

if(notas.ContainsKey("Kleberson")) System.Console.WriteLine("Kleberson encontrado");

// verificar a existencia de um valor 

if(notas.ContainsValue(10)) System.Console.WriteLine("Nota encontrada");

notas.Remove("Carlos");



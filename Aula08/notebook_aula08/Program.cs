// AULA 08 - STRUCTS

using System;

struct passagem
{
    public string origem;
    public string destino;
    public double valor;
    public string comprador;
}

class Program
{
    static void Main(string[] args)
    {
        // criando uma instância da struct
        passagem p1;

        // atribuindo valores aos campos da struct
        p1.origem = "São Paulo";
        p1.destino = "Santa Rita";
        p1.valor = 150.00;
        p1.comprador = "João Silva";

        // exibindo os valores dos campos da struct
        Console.WriteLine("Passagem 1:");
        Console.WriteLine("Origem: " + p1.origem);
        Console.WriteLine("Destino: " + p1.destino);
        Console.WriteLine("Valor: " + p1.valor);
        Console.WriteLine("Comprador: " + p1.comprador);

        // criando outra instância da struct em um vetor

        passagem[] bilhetes_vendidos = new passagem[5];
        bilhetes_vendidos[0]=p1;

        // vetor[indice(struct)].campo
        bilhetes_vendidos[1].origem = "Rio de Janeiro";
        bilhetes_vendidos[1].destino = "Salvador";
        bilhetes_vendidos[1].valor = 200.00;
        bilhetes_vendidos[1].comprador = "Maria Souza";

        bilhetes_vendidos[2].origem = "Belo Horizonte";
        bilhetes_vendidos[2].destino = "Fortaleza";
        bilhetes_vendidos[2].valor = 180.00;
        bilhetes_vendidos[2].comprador = "Carlos Pereira";

        // exibindo os valores dos campos da struct no vetor
        Console.WriteLine("\nPassagem 2:");
        Console.WriteLine("Origem: " + bilhetes_vendidos[1].origem);
        Console.WriteLine("Destino: " + bilhetes_vendidos[1].destino
        );
       
        // exibir todas as passagens do vetor bilhetes vendidos

        Console.WriteLine("\nPassagens vendidas:");
        foreach (var passagem in bilhetes_vendidos)
        {
            if (passagem.origem != null) // verificar se a passagem foi preenchida
            {
                Console.WriteLine("Origem: " + passagem.origem);
                Console.WriteLine("Destino: " + passagem.destino);
                Console.WriteLine("Valor: " + passagem.valor);
                Console.WriteLine("Comprador: " + passagem.comprador);
                Console.WriteLine();
            }
        }

    }
}
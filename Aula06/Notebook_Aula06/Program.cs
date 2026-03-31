// C#

using System;
class Program
{
    static int y = 20; //variável global
    static void Main() //FUNÇÃO PRINCIPAL
    {
        int x = 10; //variável local
        y = 10; // posso acessar a variável global aqui, pois ela existe em todo o programa
        funcao1(ref x);
        funcao2();

        System.Console.WriteLine("Valor de x na main: " + x); // o valor de x não mudou, pois é uma variável local e só existe dentro da função Main
    }


// Variáveis globais e locais
// Múltiplos chamados
    static void funcao2()
    {
        System.Console.WriteLine("funcao 2");
        System.Console.WriteLine("Valor de y: " + y); // posso acessar a variável global aqui, pois ela existe em todo o programa
        //funcao1(758); //pode chamar a função antes de defini-la!    
    }

    static void funcao1(ref int x) //pode definir a função depois de chamá-la!
    {
        System.Console.WriteLine("funcao 1");
        y = 25; // posso acessar a variável global aqui, pois ela existe em todo o programa
        System.Console.WriteLine("Valor de y: " + y );
        System.Console.WriteLine("Valor de x: " + x);  

        x = 15; 
    }
}



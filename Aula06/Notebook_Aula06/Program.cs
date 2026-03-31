// C#

using System;
class Program
{
    static int y = 20; //variável global
    static void Main() //FUNÇÃO PRINCIPAL
    {
        int x = 10; //variável local
        y = 10; // posso acessar a variável global aqui, pois ela existe em todo o programa
        funcao1();
        funcao2();
    }

    static void funcao2()
    {
        System.Console.WriteLine("funcao 2");
        funcao1(); //pode chamar a função antes de defini-la!    
    }

    static void funcao1() //pode definir a função depois de chamá-la!
    {
        System.Console.WriteLine("funcao 1");
    }
}



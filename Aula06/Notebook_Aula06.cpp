//C++

#include <iostream>
using namespace std;

int y = 20; // variável global, existe em todo o programa

void funcao1() { // preciso definir a função antes de chamá-la!
    cout << "funcao 1" << endl;
    y = 25; // posso acessar a variável global aqui, pois ela existe em todo o programa
    cout << "Valor de y: " << y << endl; // posso acessar a variável global aqui, pois ela existe em todo o programa
    int x = 5; // variável local, só existe dentro da função 1
    cout << "Valor de x: " << x << endl; // posso acessar a variável local aqui, pois ela existe dentro da função 1
}
void funcao2() {
    cout << "funcao 2" << endl;
    cout << "Valor de y: " << y << endl; // posso acessar a variável global aqui, pois ela existe em todo o programa
    funcao1(); // posso chamar a função 1 aqui, pois ela já foi definida    
}

int main() { // FUNÇÃO PRINCIPAL

    int x = 10; // variável local, só existe dentro do main
    cout << "Valor de x: " << x << endl; // posso acessar a variável local aqui, pois ela existe dentro do main
    cout << "Valor de y: " << y << endl; // posso acessar a variável global aqui, pois ela existe em todo o programa
    y = 10; // posso acessar a variável global aqui, pois ela existe em todo o programa
    funcao1();
    funcao2();
}

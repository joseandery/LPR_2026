//C++

#include <iostream>
#include <locale.h>
using namespace std;


// Variáveis globais e locais
// Múltiplos chamados

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

// RETORNOS e PARÂMETROS

// void: função sem retorno

void apresentacao(string nome) {
    cout << "Olá, " << nome << ", seja bem-vindo!" << endl;
}

// funções com retorno > tipo da função é o retorno dela

int areaDoRETANGULO(int lado1=5, int lado2=2){
    return lado1 * lado2; // retorno da função
}

double modulo(double a){
    if (a < 0) {
        return -a; // retorno da função
    }
    else {
        return a; // retorno da função
    }
}

int main() { // FUNÇÃO PRINCIPAL
    setlocale(LC_ALL, "Portuguese");

    int x = 10; // variável local, só existe dentro do main
    cout << "Valor de x: " << x << endl; // posso acessar a variável local aqui, pois ela existe dentro do main
    cout << "Valor de y: " << y << endl; // posso acessar a variável global aqui, pois ela existe em todo o programa
    y = 10; // posso acessar a variável global aqui, pois ela existe em todo o programa
    funcao1();
    funcao2();

    cout << "Retorno" << endl;
    apresentacao("Alice"); // posso chamar a função aqui, pois ela já foi definida
    
    string nome = "Carmelita";

    apresentacao(nome); // posso chamar a função aqui, pois ela já foi definida

    string nome2;
    cin >> nome2;
    apresentacao(nome2); // posso chamar a função aqui, pois ela já foi definida
    
    int area = areaDoRETANGULO(10,5); // posso chamar a função aqui, pois ela já foi definida
    cout << "Área do quadrado: " << area << endl;

    cout << "Área do quadrado com valor padrão: " << areaDoRETANGULO(10) << endl; // posso chamar a função aqui, pois ela já foi definida
    
    cout << "Área do quadrado com valor padrão: " << areaDoRETANGULO() << endl; // posso chamar a função aqui, pois ela já foi definida

    cout << "Módulo de -10: " << modulo(-10) << endl; // posso acessar a variável local aqui, pois ela existe dentro do main

    cout << "Módulo de -10,458: " << modulo(-10.458) << endl; // posso acessar a variável local aqui, pois ela existe dentro do main
}

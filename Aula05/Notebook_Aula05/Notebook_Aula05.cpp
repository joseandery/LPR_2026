#include <iostream>
#include <locale>

using namespace std;

int main(){
    setlocale(LC_ALL, "pt_BR.UTF-8");

    // ESTRUTURAS DE REPETIÇÃO

    // 1) ENQUANTO (WHILE) -> ESTRUTURA PRÉ-CONDICIONADA (PODE NÃO REPETIR O CÓDIGO)

    int contador = 0;
    int acumulador = 0;

    cout << "Estrutura WHILE:" << endl;
    while (contador < 5) // verifico a condição
    {
        cout << "Contador do While: " << contador << endl;
        contador++; //iterador
        acumulador+=contador;
        cout << "Valor intermediário do acumulador: " << acumulador << endl;
    }

    cout << "Valor final do contador: " << contador << endl;
    cout << "Valor final do acumulador: " << acumulador << endl;
    
    // 2) REPITA (DO WHILE) -> ESTRUTURA PÓS-CONDICIONADA (REPETE O CÓDIGO PELO MENOS UMA VEZ)
    
    cout << "Estrutura DO WHILE:" << endl;
    do {

        cout << "Contador do Do While: " << contador << endl;
        contador--; //iterador       

    } while (contador > 0); // verifico a condição (depois!)

    cout << "Valor final do contador: " << contador << endl;

    // 3) PARA (FOR) -> ESTRUTURA DE REPETIÇÃO CONTROLADA (ITERADOR INTERNO)

    cout << "Estrutura FOR:" << endl;

    for (int i = 0; i < 5; i++){ // iterador interno
        cout << "Contador do for: " << i << endl;
    }  
    
    cout << endl<< "Exemplo" << endl;

    int maiorValor = 0;
    int menorValor = 0;
    double acumula = 0;
    double conta = 0;

    double numero =0;
    cout << "Digite o primeiro número: "<< endl; 
    cin >> numero;

    while(numero != -1){
        if (numero < menorValor) menorValor = numero;
        if (numero > maiorValor) maiorValor = numero;
        acumula+=numero;
        conta++;        
        cout << "Digite o próximo número: "<< endl; 
        cin >> numero;

    }
    double media = acumula/conta;
    cout << "Média final: " << media;

}
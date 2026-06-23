// AULA 09 - LISTAS
#include <string>
#include <list>
#include <iostream>
using namespace std;

int main(){
    // Criação de uma nova lista
    
    list<int> numeros;

    //Adição de novos elementos

    numeros.push_back(1);
    numeros.push_back(3);
    numeros.push_back(4);
    numeros.push_back(2);
    numeros.push_back(5);

    //Varredura da lista

    for(auto it = numeros.begin(); it != numeros.end(); ++it)
    {
        cout << *it << endl;
    }

    //Métodos:
        // Quantidade de elementos

    cout << "Quantidade de elementos da lista: " << numeros.size() << endl;

        // Remoção de elementos

    numeros.remove(2);
    cout << "Removendo número 2" << endl;
    for(auto it = numeros.begin(); it != numeros.end(); ++it)
    {
        cout << *it << endl;
    }
    cout << "Quantidade de elementos da lista: " << numeros.size() << endl;

    // remover elemento em endereço específio
    auto pos = numeros.begin();
    advance(pos, 2);
    numeros.erase(pos);
    cout << "Removendo número da posição 3" << endl;
    for(auto it = numeros.begin(); it != numeros.end(); ++it)
    {
        cout << *it << endl;
    }
    cout << "Quantidade de elementos da lista: " << numeros.size() << endl;

    // adicionando elemento em posição específica
    auto pos2 = numeros.begin();
    advance(pos2, 2);
    numeros.insert(pos2, 20);
    cout << "Adicionando elemento 20 na terceira posição" << endl;
    for(auto it = numeros.begin(); it != numeros.end(); ++it)
    {
        cout << *it << endl;
    }
    cout << "Quantidade de elementos da lista: " << numeros.size() << endl;

}
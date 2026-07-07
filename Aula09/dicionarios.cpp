#include <iostream>
#include <map>

using namespace std;

int main(){
   
    // criar um dicionário
    map<string,int> notas;

    // adicionar elementos

    notas["Ana"] = 10;
    notas["Kleberson"] = 75;
    notas["Jandira"] = 90;
    
    // acessar um VALOR

    cout << "Nota da Jandira: " << notas["Jandira"] << endl;

    // alterar um VALOR

    notas["Kleberson"] = 25;

    // percorrer o dicionário

    cout << "Notas: " << endl;

    for (auto item : notas){
        cout << item.first << ": " << item.second << endl;
    }
    
    // verificar se uma chave existe 

    if (notas.find("Ana") != notas.end()){
        cout << "Ana está no dicionário" << endl;
    } else {
        cout << "Ana não está no dicionário" << endl;
    }    

    if (notas.count("Kleberson")){
        cout << "Kleberson encontrado" << endl;
    }

    notas.erase("Ana");

    notas.clear();
    
}
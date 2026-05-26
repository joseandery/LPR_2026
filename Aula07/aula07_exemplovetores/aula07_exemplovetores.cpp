#include <iostream>
using namespace std;

int main(){
    // criar um vetor

    char vogais[5];

    // atribuir valores ao vetor

    vogais[0] = 'a';
    vogais[1] = 'e';
    vogais[2] = 'i';
    vogais[3] = 'o';
    vogais[4] = 'u';

    // modificar um valor do vetor

    vogais[2] = 'x';

    // percorrer o vetor com um for tradicional

    cout << "Percorrendo o vetor usando o for tradicional: ";
    for(int i = 0; i < 5; i++){
        cout << vogais[i] << " ";
    }

    // percorrer o vetor usando o for each
    cout << "\nPercorrendo o vetor usando o for each: ";
    
    for(char elemento : vogais){
        cout << elemento << " ";
    }

}

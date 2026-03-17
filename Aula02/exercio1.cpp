#include <iostream>
#include <iomanip>
#include <locale.h>

using namespace std;

int main()
{
   setlocale(LC_ALL, "Portuguese"); 

   // variaveis  primitivas
   int varInteira = 1;
   float varFloat = 1.2;
   double varDouble = 1.2;
   char xvar = 'J';
   string varString = "Jose";

   varInteira++;

   cin >> varInteira;

   cout << "O valor do double é " << varDouble << endl;
}

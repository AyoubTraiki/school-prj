// Banque.cpp : Ce fichier contient la fonction 'main'. L'exécution du programme commence et se termine à cet endroit.

#include <iostream>
#include <string>
#include "Compte.h"

using namespace std;

int main()
{
	Compte A(50003, "Ahmed Amine", 8050.175);
	A.afficherSolde();
	A.deposerArgent(12000);
	A.afficherSolde();

}

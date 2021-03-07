#pragma once
#include <iostream>
#include <string>
#include <stdlib.h>
class Animal
	{
private:
	int age;
	char sexe;
	string nom;
public:
	Animal(int a = 0, char s = NULL, string n = "") {
		age = a;
		sexe = s;
		nom = n;
		Animal();
		Animal(const Animal &A);
		~Animal();
		void affiche()const;
		Animal(const Animal & A);
	};

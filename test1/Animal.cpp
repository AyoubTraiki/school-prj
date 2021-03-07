#include "Animal.h"
Animal::Animal(int a, char s, string n) {
	this->a = a;
	this->s = s;
	this->n = n;
	}
	Animal::Animal(const Animal &A) {
		this->a = A.a;
		this->s = A.s;
		this->n = A.n;
	}
	Animal::~Animal() {
		delete this;
	}
	void Animal::affiche()
	{
		std::cout << this->a << "," << this->s << "," << this->n << std::endl;
	}
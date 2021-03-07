#include "heure.h"
#include <iostream>
#include "DateH.h"
int main()
{
	heure h1(2, 15, 2);
	heure h2(2, 1, 3);

	DateH d(17,2, 2020, 2, 15, 2);
	DateH d1(15, 9, 2020, 2, 1, 3);
	d.affiche();
	cout << endl;
	d1.affiche();

	cout << endl;
	d > d1;
    
}


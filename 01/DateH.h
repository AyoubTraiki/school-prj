#pragma once
#include "Heure.h"

class DateH : public heure
{
	int jour, mois, annee;
public:
	DateH(int j, int m, int an, int h, int min, int s) : heure(h, min, s);
	void affiche();
	DateH& operator>(const DateH& d);
};


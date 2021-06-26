#include "DateH.h"

DateH::DateH(int j, int m, int an, int h, int min, int s)
{
	jour = j;
	mois = m;
	annee = an;
}

void DateH::affiche()
{
	string m;
	if (mois < 10)
	{
		m = "0" + to_string(mois);
	}

	string res = "Le " + to_string(jour) + "/" + m + "/" + to_string(annee);
	cout << res << "  a ";

	heure::affiche();
}

DateH& DateH::operator>(const DateH& d)
{
	if (annee > d.annee)
	{
		cout << "supérieur" << endl;
	}
	if (annee < d.annee)
	{
		cout << "inférieur" << endl;
	}
	if (annee == d.annee)
	{
		if (mois > d.mois)
		{
			cout << "supérieur" << endl;
		}
		if (mois < d.mois)
		{
			cout << "inférieur" << endl;
		}
		if (mois == d.mois)
		{
			if (jour > d.jour)
			{
				cout << "supérieur" << endl;
			}
			if (jour < d.jour)
			{
				cout << "inférieur" << endl;
			}
		}
	}
	heure::operator>(d);
	return *this;
}


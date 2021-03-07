#pragma once
#include <string>
using namespace std;

	class Compte
{
	public:
		Compte(); 
		Compte(int,string, double);
		~Compte(); 
		bool retirerArgent(double);
		void deposerArgent(double);
		void afficherSolde() const;
		bool transfererArgent(double, Compte&);

	private:
		int m_numCompte;
		string m_nomProprietaire;
		double m_solde;
};


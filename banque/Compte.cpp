#include <iostream>
#include <string>
#include "Compte.h"

using namespace std;
	Compte::Compte()
{
		this->m_numCompte = 0;
		this->m_nomProprietaire = "NULL";
		this->m_solde = 0.0;
}

	Compte::Compte(int n, string m, double s)
{
		this->m_numCompte = n;
		this->m_nomProprietaire = m;
		this->m_solde = s;
}

	Compte::~Compte()
{
		delete this;
}

bool Compte::retirerArgent(double a)
{
	if (this->m_solde >= a)
	{
		this->m_solde =m_solde - a;
		return true;
	}
	else
	{
		return false;
	}
}

void Compte::deposerArgent(double a)
{
	this->m_solde =m_solde + a;
}

void Compte::afficherSolde() const
{
	cout << " Le solde est de : " + to_string(this->m_solde) + " dh" << endl << endl;
}

bool Compte::transfererArgent(double a, Compte& cpteCible)
{
	if (this->m_solde >= a)
	{
		this->m_solde =m_solde - a;
		cpteCible.m_solde =m_solde + a;
		return true;
	}
	else
	{
		return false;
	}

}
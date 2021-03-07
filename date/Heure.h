#pragma once
#include <iostream>
#include<string>
using namespace std;
class heure
{
protected:
	int hour, minute, second;
public:
	heure(int h = 0, int m = 0, int s = 0);
	void affiche();
	heure operator>(const heure& t);
};

 
#include "heure.h"

heure::heure(int h, int m, int s)
{
	hour = h;
	minute = m;
	second = s;
}

void heure::affiche()
{
	string h, m, s;
	if (hour < 10)
	{
		h = "0" + to_string(hour);
	}
	if (minute < 10)
	{
		m = "0" + to_string(minute);
	}
	if (second < 10)
	{
		s = "0" + to_string(second);
	}
	if (hour >= 10)
	{
		h = to_string(hour);
	}
	if (minute >= 10)
	{
		m = to_string(minute);
	}
	if (second >= 10)
	{
		s = to_string(second);
	}
	string res = h + ":" + m + ":" + s;
	cout << res;
}

heure heure::operator>(const heure& t)
{
	if (this->hour > t.hour)
	{
		cout << "sup�rieur" << endl;
		return true;
	}
	if (this->hour < t.hour)
	{
		cout << "inf�rieur" << endl;
		return false;
	}
	if (this->hour == t.hour)
	{
		if (this->minute > t.minute) {
			cout << "sup�rieur" << endl;
			return true;
		}
		if (this->minute < t.minute)
		{
			cout << "inf�rieur" << endl;
			return false;
		}
		if (this->minute == t.minute)
		{
			if (this->second > t.second) {
				cout << "sup�rieur" << endl;
				return true;
			}
			if (this->second < t.second) {
				cout << "inf�rieur" << endl;
				return false;
			}
		}
	}
	return heure();
}

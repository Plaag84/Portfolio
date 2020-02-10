/*
Harjoitus 10 (Palautus vko 41)

Tee ohjelma, joka laskee sy�tetyist� kokonaisluvuista sek� positiivisten
ett� negatiivisten kokonaislukujen osuuden. Lukujen sy�tt� lopetetaan
sy�tt�m�ll� luku 0.

Tulostus:
Sy�tit kokonaislukuja seuraavasti:
----------------------------------
Negatiiviset 7 kpl 70.00%
Positiiviset 3 kpl 30.00%
Yhteens� 10 kpl 100.00%
*/

#include <iostream> 
using namespace std;
int main(void)
{
	float luku = 1;
	float positiivinen = 0;
	float negatiivinen = 0;

	while (luku != 0)
	{
		cout << "Teht�v� 10" << endl;
		cout << "Anna luku: " << endl;
		cin >> luku;
		if (luku > 0)
			positiivinen++;
		if (luku < 0)
			negatiivinen++;
	}
	float yht = (positiivinen + negatiivinen);
			
			cout << "Negatiiviset: " << negatiivinen << " kpl " << (negatiivinen * 100 / yht) << "%" << endl;
			cout << "Positiiviset: " << positiivinen << " kpl " << (positiivinen * 100 / yht) << "%" << endl;
			cout << "Yhteens�: " << yht << " kpl 100.00%" << endl;
	

	system("pause");
	return 0;
}


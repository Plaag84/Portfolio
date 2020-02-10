/*
Harjoitus 10 (Palautus vko 41)

Tee ohjelma, joka laskee syötetyistä kokonaisluvuista sekä positiivisten
että negatiivisten kokonaislukujen osuuden. Lukujen syöttä lopetetaan
syöttämällä luku 0.

Tulostus:
Syötit kokonaislukuja seuraavasti:
----------------------------------
Negatiiviset 7 kpl 70.00%
Positiiviset 3 kpl 30.00%
Yhteensä 10 kpl 100.00%
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
		cout << "Tehtävä 10" << endl;
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
			cout << "Yhteensä: " << yht << " kpl 100.00%" << endl;
	

	system("pause");
	return 0;
}


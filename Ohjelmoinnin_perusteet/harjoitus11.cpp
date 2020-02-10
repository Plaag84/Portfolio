/*
Harjoitus 11 (Palautus vko 43)
Muuta teht�v�n 9 laskin-ohjelmaa niin, etta valikko nayttaa
seuraavalta:

VALIKKO
0. Lopetus
1. Summa
2. Erotus
3. Tulo
4. Osamaara
5. Jakojaannos
6. Syota uudet luvut laskemista varten

Laskimella on siis mahdollista k�sitell�
useita lukupareja k�ytt�j�n toiveiden
mukaisesti. Mita tapahtuu, jos luku2 on 0?
HUOM! goto -lauseen k�ytt� on KIELLETTY!!!!
*/

#include <iostream> 
using namespace std;
int main()

{
	int luku1;
	int luku2;
	int valikko;
	int summa, erotus, tulo, osamaara, jaannos;
	do
	{ 
	cout << "Anna luku 1: " << endl;
	cin >> luku1;
	cout << "Anna luku 2: " << endl;
	cin >> luku2;
	if (luku2 == 0)
	{
		summa = luku1 + luku2;
		erotus = luku1 - luku2;
		tulo = luku1 * luku2;
		osamaara = 0;
		jaannos = 0;
	}
	else
	{
		summa = luku1 + luku2;
		erotus = luku1 - luku2;
		tulo = luku1 * luku2;
		osamaara = luku1 / luku2;
		jaannos = luku1 % luku2;
	}
	cout << "VALIKKO" << endl << endl;
	cout << "0. Lopetus" << endl;
	cout << "1. Summa" << endl;
	cout << "2. Erotus" << endl;
	cout << "3. Tulo" << endl;
	cout << "4. Osam��r�" << endl;
	cout << "5. Jakoj��nn�s" << endl;
	cout << "6. Sy�t� uudet luvut laskemista varten" << endl;
	cin >> valikko;
	cout << "\nLuku1: " << luku1 << " Luku2: " << luku2 << endl;
		switch (valikko)
		{
		case 1: cout << "\nSumma: " << summa;
			break;
		case 2: cout << "\nErotus: " << erotus;
			break;
		case 3: cout << "\nTulo: " << tulo;
			break;
		case 4: cout << "\nOsam��r�: " << osamaara;
			break;
		case 5: cout << "\nJakoj��nn�s: " << jaannos;
			break;
		default: cout << "\n" << endl;
			break;
		} 
	} while (valikko == 6);

	system("pause");
	return 0;
}
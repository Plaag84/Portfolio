/*
Harjoitus 11 (Palautus vko 43)
Muuta teht‰v‰n 9 laskin-ohjelmaa niin, etta valikko nayttaa
seuraavalta:

VALIKKO
0. Lopetus
1. Summa
2. Erotus
3. Tulo
4. Osamaara
5. Jakojaannos
6. Syota uudet luvut laskemista varten

Laskimella on siis mahdollista k‰sitell‰
useita lukupareja k‰ytt‰j‰n toiveiden
mukaisesti. Mita tapahtuu, jos luku2 on 0?
HUOM! goto -lauseen k‰ytt‰ on KIELLETTY!!!!
*/

/*
Harjoitus 21 (Palautus vko 48)
Muunna harjoitus 11 niin, etta k‰yt‰t seuraavia aliohjelmia:

int KysyValinta(void);

-> KysyValinta paluttaa k‰ytt‰j‰n antaman valintanumeron (0-6)

double Summa(float luku1, int luku2);

-> Summa laskee yhteen annetut tiedot ja palauttaa summan p‰‰ohjelmaan
*/


#include <iostream> 
using namespace std;
int KysyValinta(void);
double Summattu(float luku1, int luku2);
int main()

{
	int luku1;
	int luku2;
	int valikko;
	int summa;
	do
	{
		cout << "Anna luku 1: " << endl;
		cin >> luku1;
		cout << "Anna luku 2: " << endl;
		cin >> luku2;
		valikko = KysyValinta();
		cout << "\nLuku1: " << luku1 << " Luku2: " << luku2 << endl;
		switch (valikko)
 
			
		{
		case 1: summa = Summattu((float) luku1, (int) luku2);
			cout << "\nSumma: " << summa;
			break;
		case 2: cout << "\nErotus: " << luku1 - luku2;
			break;
		case 3: cout << "\nTulo: " << luku1 * luku2;
			break;
		case 4: cout << "\nOsam‰‰r‰: ";
			if (luku2 == 0)
			{
				cout << "0";
			}
			else
			{
				luku1 / luku2;
			}
			break;
		case 5: cout << "\nJakoj‰‰nnˆs: ";
			if (luku2 == 0)
			{
				cout << "0";
			}
			else
			{
				luku1 % luku2;
			}
			break;
		default: cout << "\n" << endl;
			break;
		}
	} while (valikko == 6);

	system("pause");
	return 0;
}

int KysyValinta(void) // Aliohjelman m‰‰rittely
{
	int valikko;
	cout << "VALIKKO" << endl << endl;
	cout << "0. Lopetus" << endl;
	cout << "1. Summa" << endl;
	cout << "2. Erotus" << endl;
	cout << "3. Tulo" << endl;
	cout << "4. Osam‰‰r‰" << endl;
	cout << "5. Jakoj‰‰nnˆs" << endl;
	cout << "6. Syˆt‰ uudet luvut laskemista varten" << endl;
	cin >> valikko;
	return valikko;
}
double Summattu(float luku1, int luku2)
{
	double summa;
	
	summa = luku1 + luku2;
	
	return summa;
}
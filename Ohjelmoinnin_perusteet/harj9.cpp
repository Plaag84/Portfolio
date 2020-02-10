/*
Harjoitus 9 (Palautus vko 41)
Tee ohjelma, joka toimii laskimena.
Käyttäjältä kysytään kaksi kokonaislukua,
jonka jälkeen ohjelma antaa valikon
laskutoimituksista. Valikko nayttaa
seuraavalta:

VALIKKO
1. Summa
2. Erotus
3. Tulo
4. Osamaara
5. Jakojaannos

Lopuksi ohjelma tulostaa valitun tuloksen naytölle.
*/

#include <iostream> 
using namespace std;
int main()

{
	int luku1;
	cout << "Anna luku 1: " << endl;
	cin >> luku1;
	int luku2;
	cout << "Anna luku 2: " << endl;
	cin >> luku2;
	int summa, erotus, tulo, osamaara, jaannos;
	summa = luku1 + luku2;
	erotus = luku1 - luku2;
	tulo = luku1 * luku2;
	osamaara = luku1 / luku2;
	jaannos = luku1 % luku2;
	int valikko;
	cout << "VALIKKO" << endl << endl;
	cout << "1. Summa" << endl;
	cout << "2. Erotus" << endl;
	cout << "3. Tulo" << endl;
	cout << "4. Osamäärä" << endl;
	cout << "5. Jakojäännös" << endl;
	cin >> valikko;
	cout << "\nLuku1: " << luku1 << " Luku2: " << luku2;
	if (valikko == 1) {
		cout << "\nSumma: " << summa;
	}
	if (valikko == 2) {
		cout << "\nErotus: " << erotus;
	}
	if (valikko == 3) {
		cout << "\nTulo: " << tulo;
	}
	if (valikko == 4) {
		cout << "\nOsamäärä: " << osamaara;
	}
	if (valikko == 5) {
		cout << "\nJakojäännös: " << jaannos;
	}
	system("pause");
	return 0;
}
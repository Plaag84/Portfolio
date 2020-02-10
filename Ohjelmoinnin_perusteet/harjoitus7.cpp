/*
Harjoitus 7 (palautus vko 40)

Tee ohjelma, joka kysyy käyttäjältä nimen, pituuden sentteinä ja painon kiloina. 
Ohjelma laskee ja tulostaa käyttäjän ihannepainon (pituus-100). Lisäksi
ohjelma kertoo käyttäjän nykyisen painon eron kiloina verrattuna ihanne- 
painoon. Ohjelman käyttöliittymä toimii seuraavasti:

Ihannepaino

Ohjelma laskee ihannepainosi
pituutesi perusteella.

Anna nimesi > Mooses
Anna pituutesi sentteinä > 175
Anna osoitteesi > Peikkovuori 5 as 4
Anna painosi kiloina > 89


Arvoisa Mooses
Osoitteesi on Peikkovuori 5 as 4
Nykyinen painosi 89.0 kg
Ihannepainosi 75.0 kg
Erotus 14.0 kg


Käytä cin/cout/cin.get... olioita ohjelman
toteuttamiseen (c++ metodit, kirja sivu 92 - 99)
*/

#include <iostream>
using namespace std;

int ihannepaino;
void Painolaskuri(int);
int main()
{
	cout << "Tehtävä 7" << endl;

	char nimi[30];
	cout << "Anna nimesi: " << endl;
	cin >> nimi;
		
	int pituus;
	cout << "Anna pituutesi sentteinä: " << endl;
	cin >> pituus;

	char osoite[30];
	cout << "Anna osoitteesi: " << endl;
	cin.get();
	cin.get(osoite, 30);
	
	int paino;
	cout << "Anna painosi: " << endl;
	cin >> paino;

	int ihannepaino;
		ihannepaino = pituus - 100;

		int erotus;
		erotus = paino - ihannepaino;

	cout << "Arvoisa: " << nimi;
	cout << "\nOsoitteesi on " << osoite;
	cout << "\nNykyinen painosi " << paino;
	cout << "\nIhannepainosi " << ihannepaino;
	cout << "\nErotus " << erotus << endl;



	system("pause");
	return 0;
}
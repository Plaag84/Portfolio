/*
Harjoitus 22 (Palautus vko 49)
Tee ohjelma, joka toimii henkilörekisterinä (max 10).
Ohjelma antaa käyttäjälle seuraavan valikon:

VALIKKO
0 Lopeta
1 Lisaa henkilo
2 Nayta kaikki henkilot

Tallenna henkilöiden tiedot tietuetaulukkoon.
Tallennettavia tietoja ovat
etunimi (merkkijono)
koulumatka (liukuluku)
hatun koko (kokonaisluku)

Toteuta ensin koko ohjelma pääohjelmana.

Tämän jälkeen lisää seuraavat aliohjelmat:
a) int Valikko(void);
b) void TulostaHenkilo(TIEDOT );
c) void TulostaKaikkiHenkilot(TIEDOT [], int lkm);
d) void LisaaHenkilo(TIEDOT [], int *lkm);
*/

#include <iostream> 
using namespace std;
int Menu(void);
const int MAX_PPL = 10;


struct HUMAN
{
	char name[18];
	float dist;
	int hat;
};

void TulostaHenkilo(HUMAN tyyppi);
void TulostaKaikkiHenkilot(HUMAN [], int MAX_PPL);
void LisaaHenkilo(HUMAN[], int *a);

int main()
{
	int valikko;
	cout << "Harjoitus 22" << endl;
	HUMAN tyyppi[MAX_PPL] = 
	{
    { "Esimerkki1", 0.0, 0 },
	{ "Esimerkki2", 0.0, 0 },
	{ "Esimerkki3", 0.0, 0 },
	{ "Esimerkki4", 0.0, 0 },
	{ "Esimerkki5", 0.0, 0 },
	{ "Esimerkki6", 0.0, 0 },
	{ "Esimerkki7", 0.0, 0 },
	{ "Esimerkki8", 0.0, 0 },
	{ "Esimerkki9", 0.0, 0 },
	{ "Esimerkki10", 0.0, 0 }
	};
	int a = 0;
	
	do
	{
		if (a == 0)
		{
			cout << "Nyt seurannassa: " << tyyppi[a].name << endl << endl;
		}
		else
		{
			cout << "Nyt seurannassa: " << tyyppi[a - 1].name << endl << endl;
		}
		valikko = Menu();
		switch (valikko)
		{
		case 0:
			break;
		case 1:
			LisaaHenkilo(tyyppi, &a);
			break;

			/* Pääohjelma versio
			cout << endl <<  "Anna " << a+1 << ". Henkilön etunimi: " << endl;
			cin.get(tyyppi[a].name, 18);
			cout << "Anna " << a+1 << ". Henkilön koulumatkan pituus: " << endl;
			cin >> ws >> tyyppi[a].dist;
			cout << "Anna " << a+1 << ". Henkilön hatun koko: " << endl;
			cin >> ws >> tyyppi[a].hat;
			a++;
			if (a == MAX_PPL)
			{
				a = 0;
				break;
			}
			else
			{
				break;
			}
			*/

		case 2:
			TulostaKaikkiHenkilot(tyyppi, MAX_PPL);
			break;

			/* Pääohjelman versio
			cout << endl;
			cout << endl << endl << "Nimi, Koulumatka, Hatunkoko" << endl;
			for (int k = 0; k < MAX_PPL; k++)
			{
				cout << tyyppi[k].name << ", " << tyyppi[k].dist << ", " << tyyppi[k].hat << endl;

			}
			cout << endl;
			break;
			*/

		case 3:
			if (a == 0)
			{
				TulostaHenkilo(tyyppi[a]);
			}
			else
			{
				a--;
				TulostaHenkilo(tyyppi[a]);
				a++;
			}
			break;
			

		default:
			cout << "Virheellinen valinta" << endl;
		}
	} while (valikko != 0);
	cout << endl;
	system("pause");
	return 0;
}

int Menu(void) // a)
{
	int valikko;
	cout << "VALIKKO" << endl;
	cout << "0 Lopeta" << endl;
	cout << "1 Lisaa henkilo" << endl;
	cout << "2 Nayta kaikki henkilot" << endl;
	cout << "3 Tulosta nykyinen henkilo" << endl;
	cin >> valikko;
	cin.get(); // Poistaa entterin
	return valikko;
}


void TulostaHenkilo(HUMAN tyyppi) // b) 
{
	cout << endl << "Nimi: " << tyyppi.name << endl << "Koulumatkan pituus: " << tyyppi.dist << endl << "Hatun koko: " << tyyppi.hat << endl << endl;
		
}

void TulostaKaikkiHenkilot(HUMAN a_tyyppi[], int MAX_PPL) // c)
{
	cout << endl << endl << "Nimi, Koulumatka, Hatunkoko" << endl;
	for (int dudes = 0; dudes < MAX_PPL; dudes++)
	{
		cout << a_tyyppi[dudes].name << ", " << a_tyyppi[dudes].dist << ", " << a_tyyppi[dudes].hat << endl;
	}
	cout << endl;
}

void LisaaHenkilo(HUMAN b_tyyppi[], int *a) // d)
{
	cout << endl << "Anna " << *a + 1 << ". Henkilön etunimi: " << endl;
	cin.get(b_tyyppi[*a].name, 18);
	cout << "Anna " << *a + 1 << ". Henkilön koulumatkan pituus: " << endl;
	cin >> ws >> b_tyyppi[*a].dist;
	cout << "Anna " << *a + 1 << ". Henkilön hatun koko: " << endl;
	cin >> ws >> b_tyyppi[*a].hat;
	(*a)++;
	if (*a == MAX_PPL)
	{
		*a = 0;
	}
	else
	{
	
	}

}
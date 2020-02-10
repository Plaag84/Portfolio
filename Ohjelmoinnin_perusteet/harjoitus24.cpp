// LATAUS EI VIELÄ TOIMI! (eikä tallennus ole kivasti ehkä tehty)

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

------------------------------------------------------------------

Harjoitus 24 (Palautus vko 17)
Muuta harjoitusta 22 niin, etta valikko nayttaa seuraavalta:

VALIKKO
0 Lopeta
1 Lisaa henkilo
2 Nayta henkilo
3 Nayta kaikki henkilot
4 Poista henkilon tiedot
5 Tallenna tiedot tiedostoon
6 Hae tiedot tiedostosta


ja toteuta valikossa näkyvät toiminnot.

Valitse haluamasi tallennusformaatti.
ofstream kirjoita;
kirjoita.open("tiedot.txt");
kirjoita << "Tämä menee nyt tiedostoon";
kirjoita.close();

*/

#include <iostream> 
using namespace std;
#include <fstream> // mahdollista kirjoituksen
int Menu(void);
const int MAX_PPL = 10;
#include <string>

struct HUMAN
{
	char name[18];
	float dist;
	int hat;
};

void TulostaHenkilo(HUMAN tyyppi);
void TulostaKaikkiHenkilot(HUMAN[], int MAX_PPL);
void LisaaHenkilo(HUMAN[], int *a);
void PoistaHenkilo(HUMAN c_tyyppi[], int *a);
void ValitseHenkilo(HUMAN d_tyyppi[], int *a); // Ylimääräinen juttu
void TallennaTiedostoon(HUMAN[], int MAX_PPL);
void AvaaTiedosto(HUMAN[], int MAX_PPL);

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
			cout << "Nyt seurannassa: " << a + 1 << ". " << tyyppi[a].name << endl << endl;
		}
		else
		{
			cout << "Nyt seurannassa: " << a << ". " << tyyppi[a - 1].name << endl << endl;
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
		case 4:
			PoistaHenkilo(tyyppi, &a);
			break;
		case 5:
			ValitseHenkilo(tyyppi, &a);
			break;
		case 6:
			TallennaTiedostoon(tyyppi, MAX_PPL);
			break;
		case 7:
			AvaaTiedosto(tyyppi, MAX_PPL);
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
	cout << "4 Poista henkilo" << endl;
	cout << "5 Valitse tarkasteltava henkilo" << endl;
	cout << "6 Tallenna tiedostoon" << endl;
	cout << "7 Avaa tiedosto" << endl;
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
	cout << endl << endl << "Henkilonumero, Nimi, Koulumatka, Hatunkoko" << endl;
	for (int dudes = 0; dudes < MAX_PPL; dudes++)
	{
		cout << dudes + 1 << ". " << a_tyyppi[dudes].name << ", " << a_tyyppi[dudes].dist << ", " << a_tyyppi[dudes].hat << endl;
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
void PoistaHenkilo(HUMAN c_tyyppi[], int *a) // harjoitus 24
{
	int henkilo_numero = *a;
	cout << endl << "Valitse poistettava henkilonumero " << endl;
	cin >> henkilo_numero;
	c_tyyppi[henkilo_numero - 1] = { "Poistettu", 0.0, 0 };
	cout << endl << "Henkilo " << henkilo_numero << " poistettu" << endl;

}
void ValitseHenkilo(HUMAN d_tyyppi[], int *a) // Ylimääräinen juttu
{
	int henkilo_numero = *a;
	cout << endl << "Valitse henkilonumero " << endl;
	cin >> henkilo_numero;
	*a = (henkilo_numero);

}

void TallennaTiedostoon(HUMAN tallenna[], int MAX_PPL)
{
	string filename;
	int apu = 0;
	ofstream save;
	cout << "Anna tiedoston nimi: ";
	cin >> filename;
	save.open(filename + ".dat");
	do {
		
		save << tallenna[apu].name << ";" << tallenna[apu].dist << ";" << tallenna[apu].hat << endl;
		apu++;
		
	} while (apu < MAX_PPL);

	
	save.close();

}

void AvaaTiedosto(HUMAN avaa[], int MAX_PPL)
{
	string filename;
	int apu = 0;
	ifstream load;
	cout << "Anna avattavan tiedoston nimi: ";
	cin >> filename;
	load.open(filename + ".dat");
	do {
		load.getline(avaa[apu].name, 100, ';');
		load >> avaa[apu].dist;
		load.ignore(';');
		load >> avaa[apu].hat;
		load.ignore(); // Luetaan rivinvaihtomerkki roskiin
		
		apu++;
	} while (apu < MAX_PPL);
		load.close();
}

/*
// lue tiedot
ifstream lue;
lue.open("tiedot.csv");
char jono[100];
lue.ignore(100, '\n');
// lue otsikko roskiin
for (int i = 0; i < 3; i++)
{
lue.getline(taulu[i].nimi, 100, ';');
lue.getline(taulu[i].os, 100, ';');
lue >> taulu[i].knumero;
lue.ignore(); //luetaan rivinvaihtomerkki roskiin
}
lue.close();
for (int i = 0; i < 3; i++)
cout << taulu[i].nimi << endl;
return 0;
}

*/





/*
ofstream kirjoita; //o niinkuin output, laittaa outputtia tiedostoon

ifstream lue; // i niinkuin input, ottaa inputtia tiedostosta

kirjoita.open("tiedot.txt");
kirjoita << "Tämä menee nyt tiedostoon";
kirjoita.close();
*/


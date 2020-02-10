/*

Harjoitus 17 (Palautus vko 46)
Muokkaa edellist‰ ohjelmaa siten, ett‰ edell‰ m‰‰ritelty‰ tietuetyyppi‰
k‰ytet‰‰n my‰s kahden muun "koululaisen" tietojen tallentamiseen.
N‰iden kahden muun koululaisen tiedot alustetaan ao. muuttujien
m‰‰rittelyn yhteydess‰. Ainoastaan yhden koululaisen tiedot kysyt‰‰n
k‰ytt‰j‰lt‰ edellisen teht‰v‰n tapaan.

Tulosta kolmen koululaisen tiedot koulumatkan mukaisessa
suuruusj‰rjestyksess‰ (pienimm‰st‰ suurimpaan) n‰yt‰lle

*/

#include <iostream> 
using namespace std;
struct GDPR
{
	char etunimet[20];
	char sukunimi[20];
	float koulumatka;
	char osoite[30];
	int postinumero;
	int jalka;
};


int main()
{
	GDPR tyyppi2 = { "Jaksa", "Jokunen", 1.2f, "Koulukuja 6 F 13", 40100, 40 };
	GDPR tyyppi3 = { "Matti", "Meik‰l‰inen", 48.3f, "Keskuskatu 1 B 19", 45100, 46 };
	
	cout << "Anna henkilˆntiedot ja verrataan niit‰ sitten kahteen muuhun henkilˆˆn." << endl;

	GDPR tyyppi1;
	cout << "Anna (kaikki) etunimet (merkkijono): " << endl;
	cin.get(tyyppi1.etunimet, 20);
	
	cout << "Anna keng‰nnumero (kokonaisluku): " << endl;
	cin >> ws >> tyyppi1.jalka;
	
	cout << "Anna sukunimesi (merkkijono): " << endl;
	cin.get();
	cin.get(tyyppi1.sukunimi, 20);
	
	cout << "Anna koulumatkasi kilometreiss‰ (reaaliluku): " << endl;
	cin >> ws >> tyyppi1.koulumatka;

	cout << "Anna osoitteesi: " << endl;
	cin.get();
	cin.get(tyyppi1.osoite, 30);
	
	cout << "Anna postinumerosi: " << endl;
	cin >> ws >> tyyppi1.postinumero;

	float lukux = tyyppi1.koulumatka;
	float lukuy = tyyppi2.koulumatka;
	float lukuz = tyyppi3.koulumatka;
	
	if (lukux < lukuy)
	{
		if (lukux < lukuy)
		{
			if (lukuy < lukuz)
				cout << tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl << tyyppi1.koulumatka << endl << tyyppi1.osoite << endl << tyyppi1.postinumero << endl << tyyppi1.jalka << endl << endl << tyyppi2.etunimet << " " << tyyppi2.sukunimi << endl << tyyppi2.koulumatka << endl << tyyppi2.osoite << endl << tyyppi2.postinumero << endl << tyyppi2.jalka << endl << endl << tyyppi3.etunimet << " " << tyyppi3.sukunimi << endl << tyyppi3.koulumatka << endl << tyyppi3.osoite << endl << tyyppi3.postinumero << endl << tyyppi3.jalka << endl;
			else
				cout << tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl << tyyppi1.koulumatka << endl << tyyppi1.osoite << endl << tyyppi1.postinumero << endl << tyyppi1.jalka << endl << endl << tyyppi3.etunimet << " " << tyyppi3.sukunimi << endl << tyyppi3.koulumatka << endl << tyyppi3.osoite << endl << tyyppi3.postinumero << endl << tyyppi3.jalka << endl << endl << endl << tyyppi2.etunimet << " " << tyyppi2.sukunimi << endl << tyyppi2.koulumatka << endl << tyyppi2.osoite << endl << tyyppi2.postinumero << endl << tyyppi2.jalka << endl;
		}
		else
			cout << tyyppi3.etunimet << " " << tyyppi3.sukunimi << endl << tyyppi3.koulumatka << endl << tyyppi3.osoite << endl << tyyppi3.postinumero << endl << tyyppi3.jalka << endl << endl << tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl << tyyppi1.koulumatka << endl << tyyppi1.osoite << endl << tyyppi1.postinumero << endl << tyyppi1.jalka << endl << endl << tyyppi2.etunimet << " " << tyyppi2.sukunimi << endl << tyyppi2.koulumatka << endl << tyyppi2.osoite << endl << tyyppi2.postinumero << endl << tyyppi2.jalka << endl;
	}
	else
	{
		if (lukux < lukuz)
			cout << tyyppi2.etunimet << " " << tyyppi2.sukunimi << endl << tyyppi2.koulumatka << endl << tyyppi2.osoite << endl << tyyppi2.postinumero << endl << tyyppi2.jalka << endl << endl << tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl << tyyppi1.koulumatka << endl << tyyppi1.osoite << endl << tyyppi1.postinumero << endl << tyyppi1.jalka << endl << endl << tyyppi3.etunimet << " " << tyyppi3.sukunimi << endl << tyyppi3.koulumatka << endl << tyyppi3.osoite << endl << tyyppi3.postinumero << endl << tyyppi3.jalka << endl;
		else
		{
			if (lukuy < lukuz)
				cout << tyyppi2.etunimet << " " << tyyppi2.sukunimi << endl << tyyppi2.koulumatka << endl << tyyppi2.osoite << endl << tyyppi2.postinumero << endl << tyyppi2.jalka << endl << endl << tyyppi3.etunimet << " " << tyyppi3.sukunimi << endl << tyyppi3.koulumatka << endl << tyyppi3.osoite << endl << tyyppi3.postinumero << endl << tyyppi3.jalka << endl << endl << tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl << tyyppi1.koulumatka << endl << tyyppi1.osoite << endl << tyyppi1.postinumero << endl << tyyppi1.jalka << endl;
			else
				cout << tyyppi3.etunimet << " " << tyyppi3.sukunimi << endl << tyyppi3.koulumatka << endl << tyyppi3.osoite << endl << tyyppi3.postinumero << endl << tyyppi3.jalka << endl << endl << tyyppi2.etunimet << " " << tyyppi2.sukunimi << endl << tyyppi2.koulumatka << endl << tyyppi2.osoite << endl << tyyppi2.postinumero << endl << tyyppi2.jalka << endl << endl << tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl << tyyppi1.koulumatka << endl << tyyppi1.osoite << endl << tyyppi1.postinumero << endl << tyyppi1.jalka << endl;
		}

	}

	/*
	t‰st‰ copy pastet luku merkintˆjen tilalle
	lukux tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl << tyyppi1.koulumatka << endl << tyyppi1.osoite << endl << tyyppi1.postinumero << endl << tyyppi1.jalka
	lukuy tyyppi2.etunimet << " " << tyyppi2.sukunimi << endl << tyyppi2.koulumatka << endl << tyyppi2.osoite << endl << tyyppi2.postinumero << endl << tyyppi2.jalka
	lukuz tyyppi3.etunimet << " " << tyyppi3.sukunimi << endl << tyyppi3.koulumatka << endl << tyyppi3.osoite << endl << tyyppi3.postinumero << endl << tyyppi3.jalka
	*/

	system("pause");
	return 0;



}
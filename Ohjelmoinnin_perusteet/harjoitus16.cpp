/*

Harjoitus 16 (Palautus vko 45)
Tee ohjelma, joka kysyy henkilotietosi ja tallentaa ne tietueeseen.
Tietueeseen talletetaan seuraavat tiedot:
etunimi (merkkijono; C:n merkkitaulukko)
sukunimi (merkkijono; C:n merkkitaulukko)
koulumatka (reaaliluku)
osoite (merkkijono; C:n merkkitaulukko)
postinumero (merkkijono; C:n merkkitaulukko)
kengannumero (kokonaisluku)

Ohjelma tulostaa lopuksi tietueen tiedot naytölle.

*/

#include <iostream> 
using namespace std;
struct GDPR
{
	char etunimet[20];
	char sukunimi[20];
	float koulumatka;
	char osoite[30];
	char postinumero[6];
	int jalka;
};


int main()
{
	GDPR tyyppi1;
	cout << "Anna (kaikki) etunimesi (merkkijono): " << endl;
	cin.get(tyyppi1.etunimet, 20);


	cout << "Anna kengännumero (kokonaisluku): " << endl;
	cin >> ws >> tyyppi1.jalka;

	
	cout << "Anna sukunimesi (merkkijono): " << endl;
	cin.get();
	cin.get(tyyppi1.sukunimi, 20);

	
	cout << "Anna koulumatkasi kilometreissä (reaaliluku): " << endl;
	cin >> ws >> tyyppi1.koulumatka;

	cout << "Anna osoitteesi: " << endl;
	cin.get();
	cin.get(tyyppi1.osoite, 30);

	
	cout << "Anna postinumerosi: " << endl;
	cin >> ws >> tyyppi1.postinumero;
	
	cout << tyyppi1.etunimet << " " << tyyppi1.sukunimi << endl
		<< tyyppi1.koulumatka << endl
		<< tyyppi1.osoite << endl
		<< tyyppi1.postinumero << endl
		<< tyyppi1.jalka << endl;

	system("pause");
	return 0;
}
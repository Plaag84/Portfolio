/*

Harjoitus 15 (Palautus vko 45)

Tee ohjelma, joka kysyy henkilötietosi seuraavasti:
Anna (kaikki) etunimesi (merkkijono):
Anna kengannumero (kokonaisluku):
Anna sukunimi (merkkijono):
Anna koulumatka (reaaliluku):
Anna osoitteesi:
Anna postinumero:

Ohjelma tulostaa tiedot seuraavasti:
sukunimi etunimet
osoite
postinumero
kengannumero ja koulumatka

Käytä C++:n cin- ja cout-olioita ohjelman toteuttamiseen.

*/

#include <iostream> 
using namespace std;
int main()
{
	char etunimet[20];
	cout << "Anna (kaikki) etunimesi (merkkijono): " << endl;
	cin.get(etunimet, 20);
	
	int jalka;
	cout << "Anna kengännumero (kokonaisluku): " << endl;
	cin >> jalka;
	
	char sukunimi[20];
	cout << "Anna sukunimesi (merkkijono): " << endl;
	cin.get();
	cin.get(sukunimi, 20);
	
	float koulumatka;
	cout << "Anna koulumatkasi kilometreissä (reaaliluku): " << endl;
	cin >> koulumatka;

	char osoite[30];
	cout << "Anna osoitteesi: " << endl;
	cin.get();
	cin.get(osoite, 30);
		
	char postinumero[6];
	cout << "Anna postinumerosi: " << endl;
	cin.get();
	cin.get(postinumero, 6);
	
	

	cout << sukunimi << " " << etunimet << endl;
	cout << osoite << endl;
	cout << postinumero << endl;
	cout << jalka << " " << koulumatka << endl;
	
	system("pause");
	return 0;
}
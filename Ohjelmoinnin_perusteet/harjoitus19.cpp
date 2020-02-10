/*

Harjoitus 19 (Palautus vko 47)
Tee ohjelma, joka toimii auton nopeusmittarina.
Periaate on seuraava: Näppäimistä toimii
nopeusanturina ja näyttä mittarin näyttänä.
Nopeusmittari laskee viiden viimeisen nopeuden
keskiarvon ja tulostaa sen nykyisenä nopeutena
näytälle. Negatiivinen nopeus lopettaa ohjelman.
Toiminta on siis seuraava:
Ohjelman kaynnistyksessa mittari näyttää nolla
0
0
0
0
0 (alkutila) nopeus = 0 km/h
Anna nopeus: 10
=> 2 km/h
Anna nopeus: 20
=> 6 km/h
Anna nopeus: 30
=> 12 km/h
Anna nopeus: 40
=> 20 km/h
Anna nopeus: 50
=> 30 km/h
Anna nopeus: 50
=> 38 km/h
Anna nopeus: 50
=> 44 km/h
Anna nopeus: 50
=> 48 km/h
Anna nopeus: 50
=> 50 km/h
Anna nopeus: 50
=> 50 km/h
Anna nopeus: -5
=> loppu

Käyttäjän syöte ohjelmalle lihavoitu ja kallistettu.

Toteuta kayttaen taulukkoa.

*/

#include <iostream> 
using namespace std;



int main()
{
	int nopeus[5] = { 0, 0, 0, 0, 0 };
	int karvo = (nopeus[0] + nopeus[1] + nopeus[2] + nopeus[3] + nopeus[4]) / 5;

	cout << "Tehtävä 19" << endl;
	
	cout << nopeus[0] << endl;
	cout << nopeus[1] << endl;
	cout << nopeus[2] << endl;
	cout << nopeus[3] << endl;
	cout << nopeus[4] << endl;

	cout << karvo << "(alkutila) nopeus =" << karvo << " km/h" << endl;
	
	for (int a = 0;;a++)
	{
		cout << "Anna nopeus : " << endl;
		cin >> nopeus[a];
		karvo = (nopeus[0] + nopeus[1] + nopeus[2] + nopeus[3] + nopeus[4]) / 5;
		cout << "==> " << karvo << " km/h" << endl;
			if (nopeus[a] <= 0)
			{
				break;
			}
		
			if (a == 4)
			{
				a = -1;
			} 
			
	}



	system("pause");
	return 0;
}

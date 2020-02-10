/*

Harjoitus 12 (Palautus vko 43)

Tee ohjelma, joka kysyy käyttäjältä kokonaisluvun väliltä 1-9 ja
tulostaa vastauksen perusteella seuraavan kuvion (jos vastaus on 6):

1
22
333
4444
55555
666666

Jokainen numero tulee tulostaa toistorakenten avulla erikseen lauseella:
cout << rivinro;

*/

#include <iostream> 
using namespace std;
int main()
{
	int maksimi = 9;
	int korkeus;
	cout << "Anna luku 1-9: " << endl;
	cin >> korkeus;
	if (korkeus > maksimi)
		{
		cout << "Virheellinen valinta" << endl;
		system("pause");
		return 0;
		}
	cout << endl;
		for(int rivinro = 1; rivinro <= korkeus; rivinro++)
		{
			for (int joulukuusi = 1; joulukuusi <= rivinro; joulukuusi++)
				cout << rivinro;
				cout << endl;
				
				
		
		}



		


		system("pause");
		return 0;
}
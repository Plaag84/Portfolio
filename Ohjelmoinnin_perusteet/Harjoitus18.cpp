/*

Harjoitus 18 (Palautus vko 46)
Tee ohjelma, joka kysyy viiden koiran nimet ja i‰t.
Tiedot tallennetaan tietuetaulukkoon.
a) j‰rjest‰ tiedot ik‰ -kent‰n mukaan suuruusj‰rjestykseen
(pienimm‰st‰ suurimpaan). Ohjelma tulostaa lopuksi
jarjestetyn taulukon n‰yt‰lle.
b) j‰rjest‰ tiedot nimi -kent‰n mukaan aakkosj‰rjestyksess‰
Ohjelma tulostaa lopuksi jarjestetyn taulukon n‰ytolle.

Lajittelu tulee toteuttaa siten, ett‰ se toimisi samoin
my‰s 50 tai 5000 koiran tapauksssa.

*/

// Harjoitus 18 a)

/*

#include <iostream> 
using namespace std;

const int MAX_DOGZ = 5;

struct DOGZ
{
	char name[20];
	int age;
};


int main()
{
	cout << "Syˆt‰ yhteens‰ viiden (5) koiran nimi ja ik‰, niin ohjelma j‰rjest‰‰ koirat ik‰j‰rjestykseen " << endl;
	
	DOGZ hurtat[MAX_DOGZ];
	
	for (int m = 0; m < MAX_DOGZ; m++)
	{
		cout << m + 1 << ". Koiran nimi: " << endl;
		cin.get(hurtat[m].name, 20);

		cout << m + 1 << ". Koiran ik‰: " << endl;
		cin >> ws >> hurtat[m].age;
		cin.get();

	}
	
	
	cout << "Vaihtolajittelu" << endl;
	
	for (int i = 0; i < (MAX_DOGZ - 1); i++) // i:t‰ tulostetaan niin kauan kunnes maksimitaulu tulee t‰yteen ja joka kertaa kun yksi i tulee t‰yteen niin lis‰t‰‰n i
	{


		for (int j = i + 1; j < MAX_DOGZ; j++) // i pysyy samana ja kasvatetaan vain j:t‰, kasvatetaan j:t‰ niin kauan ett‰ max_taulukko tulee t‰yteen, sitten loopataan takas ylemm‰ksi
		{
			// cout << i << j << endl;
			
			if (hurtat[i].age > hurtat[j].age)
			{
				DOGZ temp = hurtat[i]; // aputaulukko johon sijoitetaan hetkellisesti numero kun siirret‰‰n numeroa toiseen kohtaan
				hurtat[i] = hurtat[j];
				hurtat[j] = temp;
				
				

			}
			
		}
	}
	
	int k = 0;

	cout << "J‰rjestetyt koirat i‰n mukaan: ";
	for (int k = 0; k < MAX_DOGZ; k++)
	{
		cout << "\n" << hurtat[k].age << " " << hurtat[k].name;

	}

	system("pause");
	return 0;
}

*/

// Harjoitus 18 b)

#include <iostream> 
#include <cstring>
using namespace std;

const int MAX_DOGZ = 5;

struct DOGZ
{
	char name[20];
	int age;
};


int main()
{
	cout << "Syˆt‰ yhteens‰ viiden (5) koiran nimi ja ik‰, niin ohjelma j‰rjest‰‰ koirat ik‰j‰rjestykseen " << endl;

	DOGZ hurtat[MAX_DOGZ];

	for (int m = 0; m < MAX_DOGZ; m++)
	{
		cout << m + 1 << ". Koiran nimi: " << endl;
		cin.get(hurtat[m].name, 20);

		cout << m + 1 << ". Koiran ik‰: " << endl;
		cin >> ws >> hurtat[m].age;
		cin.get();

	}


	cout << "Vaihtolajittelu" << endl;

	for (int i = 0; i < (MAX_DOGZ - 1); i++) // i:t‰ tulostetaan niin kauan kunnes maksimitaulu tulee t‰yteen ja joka kertaa kun yksi i tulee t‰yteen niin lis‰t‰‰n i
	{


		for (int j = i + 1; j < MAX_DOGZ; j++) // i pysyy samana ja kasvatetaan vain j:t‰, kasvatetaan j:t‰ niin kauan ett‰ max_taulukko tulee t‰yteen, sitten loopataan takas ylemm‰ksi
		{
			// cout << i << j << endl;

			if (strcmp(hurtat[i].name, hurtat[j].name) > 0 ) // b) - kohta
			{										// strcmp(...) kirja s. 121-122
				DOGZ temp = hurtat[i]; // aputaulukko johon sijoitetaan hetkellisesti numero kun siirret‰‰n numeroa toiseen kohtaan
				hurtat[i] = hurtat[j];
				hurtat[j] = temp;



			}

		}
	}

	int k = 0;

	cout << "J‰rjestetyt koirat nimen mukaan: ";
	for (int k = 0; k < MAX_DOGZ; k++)
	{
		cout << "\n" << hurtat[k].age << " " << hurtat[k].name;

	}

	system("pause");
	return 0;
}

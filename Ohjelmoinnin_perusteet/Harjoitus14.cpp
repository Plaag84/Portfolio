/*
Harjoitus 14 (Palautus vko 45)

T�SS� TEHT�V�SS� ON K�YTETT�V� C-kielen merkkitaulukoita! Taulukon m��rittely on siis muotoa

char mjono[xx];

Tee ohjelma, joka kysyy k�ytt�j�lt� 17 merkki�
pitk�n merkkijonon (ei v�lily�ntej�).
a) Ohjelma tulostaa merkkijonon k��nteisess� j�rjestyksess� n�yt�lle
(tulostus tyyppi� "cout << mjono1[4];" jne)
b) Ohjelma k��nt�� annetun merkkijonon toiseen
merkkijonoon ja tulostaa sen n�yt�lle
(tulostus tyyppi� "cout << mjono2;")
c) merkkijono voi olla kuinka pitk�
tahansa (max 100 kirjainta).
Sy�tetyn merkkijonon pituutta ei saa
laskea mill��n kirjastofunktiolla
(esim. lenght tms.) Ohjelma
tutkii onko annettu merkkijono
palindromi ja ilmoittaa sen k�ytt�j�lle.
V�lily�nnit jonossa ovat sallittuja.

K�ytt�j� sy�tt�� jonon: ABC_Kissa_kavelee
ohjelma tulostaa: eelevak_assiK_CBA
*/

// A) 
/*
#include <iostream> 
using namespace std;
#include <cstring>
int main()
{
	char mjono[18];
	int pituus;
	cout << "Sy�t� maksimissaan 17 merkkijonon mittainen merkkijono: " << endl;
	cin >> mjono;
	pituus = strlen(mjono);
	pituus--;
	while (pituus >= 0)
	{
		cout << mjono[pituus];
		pituus--;
	} 
	
	
	system("pause");
	return 0;
}
*/
// B)
/*
#include <iostream> 
using namespace std;
#include <cstring>
int main()
{
	char mjono[18];
	char mjono2[18];
	cout << "Sy�t� maksimissaan 17 merkkijonon mittainen merkkijono: " << endl;
	cin >> mjono;
/*
	mjono2[0] = mjono[16];
	mjono2[1] = mjono[15];
	mjono2[2] = mjono[14];
	mjono2[3] = mjono[13];
	mjono2[4] = mjono[12];
	mjono2[5] = mjono[11];
	mjono2[6] = mjono[10];
	mjono2[7] = mjono[9];
	mjono2[8] = mjono[8];
	mjono2[9] = mjono[7];
	mjono2[10] = mjono[6];
	mjono2[11] = mjono[5];
	mjono2[12] = mjono[4];
	mjono2[13] = mjono[3];
	mjono2[14] = mjono[2];
	mjono2[15] = mjono[1];
	mjono2[16] = mjono[0];
	mjono2[17] = mjono[17];
	mjono2[18] = mjono[18];
*/
/*
	for (int i = 0, j = 16; j >= 0; i++, j--)
	{
		mjono2[i] = mjono[j];

	} 
	mjono2[17] = '\0';

	cout << mjono2 << endl;

	system("pause");
	return 0;
}
*/
/*

Harjoitus 14 (Palautus vko 45)

T�SS� TEHT�V�SS� ON K�YTETT�V� C - kielen merkkitaulukoita!Taulukon m��rittely on siis muotoa

char mjono[xx];

c) merkkijono voi olla kuinka pitk�
tahansa(max 100 kirjainta).
Sy�tetyn merkkijonon pituutta ei saa
laskea mill��n kirjastofunktiolla
(esim.lenght tms.) Ohjelma
tutkii onko annettu merkkijono
palindromi ja ilmoittaa sen k�ytt�j�lle.
V�lily�nnit jonossa ovat sallittuja.

K�ytt�j� sy�tt�� jonon : ABC_Kissa_kavelee
ohjelma tulostaa : eelevak_assiK_CBA

*/

// C)

#include <iostream> 
using namespace std;
#include <cstring>
int main()
{
	const int MAX = 100;
	char jono1[MAX + 1];
	char jono2[MAX + 1];
	int pituus;
	cout << "Anna maksimissaan " << MAX << " merkkijonon mittainen merkkijono : " << endl;
	cin.get(jono1, MAX);
	cout << "c) Alkuper�inen jono: " << jono1 << endl;
	for (pituus = 0; jono1[pituus] != '\0'; pituus++);
	cout << "Merkkijonossa on kerkkej� " << pituus << " kpl" << endl;
	jono2[pituus] = '\0';
		for (int i = 0, j = pituus - 1; j >= 0; i++, j--)
		{
			jono2[i] = jono1[j];
		}
	cout << jono2 << endl;
		if (strcmp(jono1, jono2) == 0) // vertailee onko jono1 jono2
		{
			cout << "Sana oli palindromi!" << endl;
		}
		else
		{
			cout << "Sana ei ollut palindromi." << endl;
		}
		 
	system("pause");
	return 0;
}

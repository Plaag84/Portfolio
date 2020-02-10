#include <iostream> // esik‰‰nt‰j‰, input output stream
using namespace std; // standard nimiavaruus

// vakioiden m‰‰rittely
#define MINIMI 10 // vanha tapa, EI SUOSITELLA, kannattaa kuitenkin k‰ytt‰‰ vakioissa aina isoja kirjaimia
const int MAKSIMI = 20; // uusi tapa, SUOSITELTAVA CONST contastant <- vakio. Int kokonaisluku, on huonon tavan mukaista k‰ytt‰‰ pieni‰ kirjaimia vakioissa

// muuttujien m‰‰rittely
int summa; // muuttujat hyv‰ntavan mukaan ALKAVAT aina pienell‰, turvallisia on k‰ytt‰‰ kirjaimet a-z ja numerot 0-9, erikoismerkeist‰ _

// aliohjelmien esittely
void Laske(int, int); // alkaa tyyppillisesti isolla kirjaimella

int main() //p‰‰ohjelma alkaa t‰st‰
{
	int luku1 = 2; // muuttujien m‰‰rittely, annettu etuk‰teen
	int luku2; // muuttujien m‰‰rittely
	cout << "Syˆt‰ luku: "; // k‰ytt‰j‰n antama luku
	cin >> luku2; // CONSOLE IN, k‰ytt‰j‰n vastaus =  luku 2
	Laske(luku1, luku2); // aliohjelma laske, suorittaa alhaalla olevan ohjelman
	if (summa < MINIMI) // vertaa lukuun MAX
		cout << "Summa on pienempi kuin " << MINIMI // tulostaa t‰m‰n jos tosi
	<< endl;
	if (summa > MAKSIMI) // vertaa lukuun max
		cout << "Summa on suurempi kuin " << MAKSIMI // tulostaa t‰m‰n jos tosi
	<< endl;
	if (summa > MINIMI)
		if (summa < MAKSIMI)
		cout << "Summa on MINIMIN ja MAKSIMIN v‰liss‰" << endl;
	system("pause");
	return 0;
}
void Laske(int eka, int toka) // aliohjelma Laske alkaa t‰st‰
{
	summa = eka + toka; // aliohjelman funktio
}
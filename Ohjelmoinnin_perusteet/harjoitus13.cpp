/*
Harjoitus 13 (Palautus vko 43)
Tee ohjelma, joka kysyy etunimesi ja sukunimesi. Ohjelma
yhdistää nimet yhdeksi merkkijonoksi ja tulostaa ne
lopuksi naytölle.


a) Kayta cstring-kirjastoa (C:n merkkitaulukot)
tehdäksesi merkkijonojen yhdistämisen
b) Kayta string-kirjastoa (C++:n merkkijonot)
tehdäksesi merkkijonojen yhdistämisen  TEE, JOS ON AIKAA

Esimerkki
Anna etunimi: Aku
Anna sukunimi: Ankka
Nimesi oli: Aku Ankka
*/

#include <iostream> 
using namespace std;
int main()
#include <cstring>
{
	char enimi[20] = "Aku";
	char snimi[20] = "Ankka";
	char tyhja[2] = " ";
	char knimi[40] = "";
	cout << "Anna etunimi: " << endl;
	cin >> enimi;
	cout << "Anna sukunimi: " << endl;
	cin >> snimi;
	strcat_s(knimi, enimi);
	strcat_s(knimi, tyhja);
	strcat_s(knimi, snimi);
	cout << knimi;
	system("pause");
	return 0;
}

/*
Harjoitus 8 (palautus vko 41)
Tee ohjelma, joka tulostaa annetut kolme lukua suuruus-
j�rjestyksess� (pienimm�st� suurimpaan) n�yt�lle
(katso harj. 1 suunnitelma)
a) k�yt� kokonaislukuja
b) k�yt� liukulukuja (=reaalilukuja)

*/

#include <iostream>
using namespace std;

int main()
{
	cout << "Teht�v� 8" << endl;

	float lukux;
	cout << "Anna luku 1" << endl;
	cin >> lukux;

	float lukuy;
	cout << "Anna luku 2" << endl;
	cin >> lukuy;

	float lukuz;
	cout << "Anna luku 3" << endl;
	cin >> lukuz;

	if (lukux < lukuy)
	{
		if (lukux < lukuy)
		{
			if (lukuy < lukuz)
				cout << lukux << ", " << lukuy << ", " << lukuz << endl;
			else
				cout << lukux << ", " << lukuz << ", " << lukuy << endl;
		}
		else
			cout << lukuz << ", " << lukux << ", " << lukuy << endl;
	}
	else
	{
		if (lukux < lukuz)
			cout << lukuy << ", " << lukux << ", " << lukuz << endl;
		else
		{
			if (lukuy < lukuz)
				cout << lukuy << ", " << lukuz << ", " << lukux << endl;
			else
				cout << lukuz << ", " << lukuy << ", " << lukux << endl;
		}

	}

	system("pause");
	return 0;

}
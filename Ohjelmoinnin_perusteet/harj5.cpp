#include <iostream>
using namespace std;

// muuttujien m��rittely
int luku1;
int luku2;

// p��ohjelma alkaa
void main()
{
	int luku1;
	cout << "Sy�t� luku1: " << endl;
	cin >> luku1;
	cout << "Sy�t� luku2: " << endl;
	cin >> luku2;
		if (luku1 == luku2)
			cout << "BINGO";
		else
			cout << "BONGO";
		system("pause");
}
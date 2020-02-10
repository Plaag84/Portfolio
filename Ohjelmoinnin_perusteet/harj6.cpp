#include <iostream>
using namespace std;

// muuttujien m‰‰rittely
int lompakko;
int lihapiirakka;



// p‰‰ohjelma alkaa
void main()
{
	int lompakko;
	cout << "Paljonko sinulla on rahaa lompakossa?: " << endl;
	cin >> lompakko;
	cout << "Paljonko lihapiirakka maksaa?: " << endl;
	cin >> lihapiirakka;
	if (lompakko == lihapiirakka)
	{
		cout << "Riitt‰‰ juuri ja juuri, rahaa j‰‰: ";
		cout << lompakko - lihapiirakka << endl;
	}
	if (lompakko < lihapiirakka)
	{
		cout << "Rahat eiv‰t riit‰, sinun tulee paastota" << endl; 
	}
	if (lompakko > lihapiirakka)
	{
		cout << "Rahaa riitt‰‰ ja j‰‰: ";
		cout << lompakko - lihapiirakka << endl;
	}
		system("pause");
	
}

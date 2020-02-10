#include <iostream> // input-output console

#include <string> // mahdollistaa string komennot
#include <windows.h> // t‰t‰ tarvitaan muuttamaan tekstin v‰ri‰
#include <fstream> // mahdollistaa tallentamisen

using namespace std;

struct H÷PER÷ // rakennetaan peli‰ varten tarvittava esineistˆ ja pelaajan nimi
{
	char nimi[25]; // Pelaajan nimi
	// Tavaroita joita voi saada pelin aikana
	bool avain = false; 
	bool taskulamppu = false;
	bool kaukos‰‰din = false;
	bool vaatteet = false;
	bool saunan_avain = false;
	// Paikkoja joissa pelaaja voi k‰yd‰, jotka muuttavat tunnettujen paikkojen nimi‰
	bool olohuone = false;
	bool ullakko = false;
	bool makuuhuone = false;
	bool piha = false;
	bool sauna = false;
	bool huussi = false;
	// Tapahtuma joka muuttaa pelin kulkua
	bool unet = false;
	
};
// Vied‰‰n kaikkiin huoneisiin tai alueisiin, tarina osoitin + teksti osoitin ja tavarat taulukon tiedot. Tavarat taulukon tiedot tuodaan myˆs ulos jokaisesta paikasta.
H÷PER÷ Olohuone(int *, string *, H÷PER÷ tavarat);
H÷PER÷ Ullakko(int *, string *, H÷PER÷ tavarat);
H÷PER÷ Makuuhuone(int *, string *, H÷PER÷ tavarat);
H÷PER÷ Piha(int *, string *, H÷PER÷ tavarat);
H÷PER÷ Sauna(int *, string *, H÷PER÷ tavarat);
H÷PER÷ Huussi(int *, string *, H÷PER÷ tavarat);

/*
Muistilista ascii-hexoille joilla ohjelmassa tehd‰‰n ‰‰kkˆsi‰
 \x84 = ‰
 \x8E = ƒ
 \x94 = ˆ
 \x99 = ÷
*/

/*
-----------------------------------------------------------------------------------------------------------
|
|
|								PƒƒOHJELMA
|
|
-----------------------------------------------------------------------------------------------------------
*/

int main()
{
	string *teksti = new string; // Koko ohjelman geneerinen teksti ruutu, joka tuodaan jokaisen tapahtuman j‰lkeen. T‰ll‰ rivill‰ luodaan osoittimesta suoraan uusi muuttuja
	int *tarina = new int; // Koko ohjelman liikutin tai edistymis osoitin, joka palautetaan jokaisesta aliohjelmasta p‰‰ohjelmalle, jossa p‰‰ohjelma osaa siirt‰‰ pelaajaa oikeisiin huoneisiin ja tapahtumiin
	*tarina = 0;
	H÷PER÷ tavarat = { "nimi",false,false,false,false,false,false,false,false,false,false,false,false }; // Alustetaan pelaaja, nimi ja kaikki tavarat falseja
	system("Color 0F"); // vaihdetaan taustav‰ri musta ja tekstiv‰ri valkoinen
	cout << "Kuka olet? : ";
	cin.get(tavarat.nimi, 25);
	system("CLS"); // pyyhit‰‰n ruutu
	*teksti = "Her\x84\x84t alastomana sohvalta, sinulla on kylm\x84 etk\x84 muista miss\x84 olet ja mit\x84 olet tehnyt. On keskiy\x94 \nOlet yksin.";
	cout << tavarat.nimi << endl;
	tavarat = Olohuone(tarina, teksti, tavarat); // Pelaaja vied‰‰n olohuoneeseen, ennen kuin p‰‰ohjelman switch valikko alkaa, koska ensimm‰inen switch arvo saadaan vasta olohuoneesta.
	do
	{
		switch(*tarina)
		{
		case 0:
			break;
		case 1:
			tavarat= Olohuone(tarina, teksti, tavarat); // "tavarat =" komento varmistaa ett‰ tavarat tuodaan myˆs aliohjelmasta takaisin
			break;
		case 2:
			tavarat= Makuuhuone(tarina, teksti, tavarat);
			break;
		case 3:
			tavarat= Ullakko(tarina, teksti, tavarat);
			break;
		case 4:
			tavarat= Piha(tarina, teksti, tavarat);
			break;
		case 5:
			tavarat= Huussi(tarina, teksti, tavarat);
			break;
		case 6:
			tavarat= Sauna(tarina, teksti, tavarat);
			break;

		default:
			break;
		}
	} while (*tarina != 0);
	system("CLS");
	if (tavarat.sauna == false)
	{
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 12); // Vaihdetaan konsolin tekstiominaisuutta, kohdistetaan se ulostulevaan kahvaan, v‰ri 12 = kirkas punainen
		cout << "H\x84visit pelin :(" << endl << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14); // kirkas keltainen
		cout << *teksti << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15); // valkoinen
	}
	else
	{
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 13); // kirkas pinkki
		cout << "Happy ending!" << endl << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		cout << *teksti;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		char paikka0[100]; // luodaan viimeisimm‰t l‰pipelanneet pelaajat taulukkopaikat
		char paikka1[100];
		char paikka2[100];
		char paikka3[100];
		char paikka4[100];
		char paikka5[100];
		char paikka6[100];
		char paikka7[100];
		char paikka8[100];
		char paikka9[100];
		ifstream load; // ladataan paikat edell‰ luotuihin char paikkoihin
		load.open("hall_of_fame.jee");
		load.getline(paikka0, 100, '\n');
		load.getline(paikka1, 100, '\n');
		load.getline(paikka2, 100, '\n');
		load.getline(paikka3, 100, '\n');
		load.getline(paikka4, 100, '\n');
		load.getline(paikka5, 100, '\n');
		load.getline(paikka6, 100, '\n');
		load.getline(paikka7, 100, '\n');
		load.getline(paikka8, 100, '\n');
		load.getline(paikka9, 100, '\n');
		load.close();
		strcpy_s (paikka0, paikka1); // siirret‰‰n jokaista aiemmin l‰p‰issytt‰ pelaajaa yhdell‰ ylˆsp‰in, mutta paikkaa 0 ei siirret‰ mihink‰‰n vaan se korvataan paikalla 1 
		strcpy_s (paikka1, paikka2);
		strcpy_s (paikka2, paikka3);
		strcpy_s (paikka3, paikka4);
		strcpy_s (paikka4, paikka5);
		strcpy_s (paikka5, paikka6);
		strcpy_s (paikka6, paikka7);
		strcpy_s (paikka7, paikka8);
		strcpy_s (paikka8, paikka9); // paikalle 9 tulee sitten tilalle uusin nyt l‰p‰issyt pelaaja
		ofstream save; // tallennetaan uusin pelaaja tulostamalla uudelleen j‰rjestetty taulukko
		save.open("hall_of_fame.jee");
		save << paikka0 << endl << paikka1 << endl << paikka2 << endl << paikka3 << endl << paikka4 << endl << paikka5 << endl << paikka6 << endl << paikka7 << endl << paikka8 << endl << tavarat.nimi;
		save.close();
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 13);
		cout << endl << endl << "Viimeisimm\x84t 10 l\x84p\x84isij\x84\x84." << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		// tulostetaan uudelleen j‰rjestetty taulukko
		cout << paikka0 << endl << paikka1 << endl << paikka2 << endl << paikka3 << endl << paikka4 << endl << paikka5 << endl << paikka6 << endl << paikka7 << endl << paikka8 << endl << tavarat.nimi;
	}
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10);
	cout << endl << endl << "Ohjelma loppui!" << endl << "Kiitos kun pelasit" << endl;
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
	system("pause");
	return 0;
}

/*
-----------------------------------------------------------------------------------------------------------
|
|
|								OLOHUONE
|
|
-----------------------------------------------------------------------------------------------------------
*/


H÷PER÷ Olohuone(int *tarina, string *teksti, H÷PER÷ tavarat) // Vied‰‰n H÷PER÷ struct aliohjelmaan sek‰ muuttujat tarina, teksti ja hˆperˆ tavarat. 
{
	char valikko; // switch valikko toteutetaan CHAR muodossa, ettei se hajoa jos pelaaja antaa vahingossa kirjaimen!
	for (;;) // ikisilmukka
	{
		system("CLS"); // clearaa konsolin
		if (tavarat.vaatteet == false) // tarkastetaan onko pelaaja jo lˆyt‰nyt vaatteet, jos ei ole, niin muistutetaan pelaajaa etsim‰‰n vaatteita
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 9);
			cout << "Olet alasti, sinulla on kylm\x84." << endl;

		}
		if (tavarat.olohuone == false) // t‰m‰ tarvitaan siihen kun pelaaja tulee ensimm‰ist‰ kertaa olohuoneeseen, niin *teksti clearataan , jatkossa t‰t‰ rivi‰ ei tarvita.
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
			cout << *teksti << endl << endl;
			*teksti = "";
		}
		tavarat.olohuone = true; // asetetaan merkki ett‰ huoneessa on k‰yty, (kts. rivi 185)
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		cout << "N\x84" "et yl\x94s menev\x84t portaat, sohvan, television joka on keskell\x84 huonetta p\x94yd\x84n p\x84\x84ll\x84, kaappeja, keitti\x94" "alueen, jukkapalmun, ikkunat pohjoiseen, l\x84nteen ja etel\x84\x84n, sek\x84 ovet it\x84\x84n ja etel\x84\x84n" << endl << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		if (tavarat.ullakko == true) // t‰ll‰ tarkistetaan onko pelaaja jo k‰ynyt ullakolla, jos on niin pelaaja tuntee ullakon ullakkona, muuten aluetta kutsutaan "mene portaat ylˆs"
		{
			cout << "1. Mene ullakolle" << endl;
		}
		else
		{
			cout << "1. Mene portaat yl\x94s" << endl;
		}
		cout << "2. Katso ikkunoista ulos" << endl;
		if (tavarat.makuuhuone == true)
		{
			cout << "3. Mene makuuhuoneeseen" << endl;
		}
		else
		{
			cout << "3. Mene ovesta it\x84\x84n" << endl;
		}
		if (tavarat.piha == true)
		{
			cout << "4. Mene ovesta pihalle" << endl;
		}
		else
		{
			cout << "4. Mene ovesta etel\x84\x84n" << endl;
		}
		cout << "5. Tutki keitti\x94" << endl;
		cout << "6. Laita TV p\x84\x84lle" << endl;
		cout << "7. K\x84y jukkapalmulla" << endl;
		cout << "8. K\x84y kaapilla" << endl;
		cout << "9. Tutki sohvaa" << endl;
		if (*teksti == "L\x94ysit kaukos\x84\x84timen nuudeleiden keskelt\x84") // jos pelaaja lˆyt‰‰ kaukos‰‰timen, tarkistetaan onko *teksti arvo sama kuin sille on annettu, ja siin‰ tapauksessa tulostetaan teksti eri v‰rill‰
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10); 
		}
		else
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		}
		cout << endl << *teksti << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "Valitse toiminto: ";
		cin >> valikko;
		switch (valikko) // switch valikko alkaa ja se k‰sittelee numeroita merkkein‰, eik‰ numeroina, kts rivi 175
		{
		case '1':
			*tarina = 3; // vied‰‰n p‰‰ohjelmaa varten uusi alue
			break;
		case '2':
			*teksti = "Katsot ulos ikkunoista, n\x84" "et pime\x84\x84.";
			break;
		case '3':
			*tarina = 2;
			break;
		case '4':
			if (tavarat.vaatteet == true && tavarat.taskulamppu == true) // tarkistetaan pelaajan tavarat, voiko pelaaja edet‰ ulos.
			{
				*tarina = 4;
			}
			else if (tavarat.vaatteet == true && tavarat.taskulamppu == false) // jos vain toinen tavara on saatu
			{
				*teksti = "Ovi vie ulos, et n\x84" "e mit\x84\x84n, tarvitset taskulampu.n";
			}
			else if (tavarat.vaatteet == false && tavarat.taskulamppu == true) // jos vain toinen tavara on saatu
			{
				*teksti = "Ovi vie ulos, sinulla on kylm\x84, tarvitset vaatteet.";
			}
			else // jos kumpaakaan tavaraa ei ole saatu
			{
				*teksti = "Ovi vie ulos, sinulla on kylm\x84, tarvitset vaatteet, et n\x84" "e mit\x84\x84n, tarvitset taskulampun.";
			}
			break;
		case '5':
			*teksti = "Keitti\x94ss\x84 tutkit j\x84\x84kaapin. Sy\x94t eiliselt\x84 j\x84\x84neet pitsan reunat. Kylm\x84n\x84. Et tunne oloasi hyv\x84ksi.";
			break;
		case '6':
			if (tavarat.kaukos‰‰din == true && tavarat.unet == false) // muutetaan outputtia sen mukaan onko pelaaja nauttinut "unet"
			{
				*teksti = "Avasit television, siell\x84 py\x94rii aamu-tv. Aiheena on joulupukin absurdinopeus jouluaattona ja taika-pasi. Kello on 06:30. Suljet television.";
			}
			else if (tavarat.kaukos‰‰din == true && tavarat.unet == true) // jos pelaaja on nukkunut, on kello siirtynyt TV:ss‰ tunnilla
			{
				*teksti = "Avasit television, siell\x84 py\x94rii aamu-tv. Aiheena on aamusauna jouluaattona. Kello on 07:30. Suljet television.";
			}
			else // TV:t‰ ei saa auki, ilman kaukos‰‰dint‰
			{
				*teksti = "Mekaaniset napit ovat jumissa, tarvitset kaukos\x84\x84timen.";
			}
			break;
		case '7':
			*teksti = "Jukkapalmu on mielest\x84si kasvanut senttej\x84 sitten viimen\x84kem\x84n. P\x84\x84t\x84t kastella Jukkapalmun, mutta kaadat vedet lattialle.";
			break;
		case '8':
			if (tavarat.kaukos‰‰din == false) // jos pelaajalta puuttuu kaukos‰‰din, se annetaan h‰nelle
			{
				tavarat.kaukos‰‰din = true;
				*teksti = "L\x94ysit kaukos\x84\x84timen nuudeleiden keskelt\x84";
			}
			else // jos pelaajalla jo on kaukos‰‰din, h‰n ei lˆyd‰ uutta kaukos‰‰dint‰
			{
				*teksti = "Kaapissa on nuudeleita.";
			}
			break;
		case '9':
			if (tavarat.vaatteet == true)
			{
				*teksti = "Sohvalla on viltti jonka alla nukuit.";
			}
			else
			{
				*teksti = "Sohvalla on viltti jonka alla nukuit. Sohva olisi l\x84mmin, mutta on aika etsi\x84 vaatteet p\x84\x84lle.";
			}
			break;

		default: // default, jos pelaaja antaa virheit‰ niin palautetaan takaisin looppiin
			*teksti = "Virheellinen valinta."; 
			continue;
		}
		if (*tarina == 3) // n‰ill‰ arvoilla tullaan ikisilmukasta ulos
		{
			break;
		}
		if (*tarina == 2)
		{
			break;
		}
		if (*tarina == 4)
		{
			break;
		}
		else // muuten jatketaan
		{
			continue;
		}

	}
	return tavarat;
}

/*
-----------------------------------------------------------------------------------------------------------
|
|
|								ULLAKKO
|
|
-----------------------------------------------------------------------------------------------------------
*/

H÷PER÷ Ullakko(int *tarina, string *teksti, H÷PER÷ tavarat)
{
	tavarat.ullakko = true; // annetaan taas aluevaltauksesta tieto struct rakenteeseen
	*teksti = "Saavuit ullakolle.";
	char valikko;
	for (;;)
	{
		system("CLS");
		if (tavarat.vaatteet == false)
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 9);
			cout << "Olet alasti, sinulla on kylm\x84." << endl;

		}
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		cout << "N\x84" "et ikkunat pohjoiseen ja it\x84\x84n, sek\x84 4 s\x84nky\x84, komeron ullakon p\x84\x84" "dyss\x84, ja portaat alas olohuoneeseen." << endl << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "1. Mene olohuoneeseen" << endl;
		cout << "2. Katso ikkunoista ulos" << endl;
		cout << "3. K\x84y makaamaan" << endl;
		cout << "4. Tutki s\x84ngyt" << endl;
		cout << "5. Avaa komero" << endl;
		if (*teksti == "Avasit komeron oven l\x94yt\x84m\x84ll\x84si avaimella, komerossa on patjoja ja vuodeliinoja, sek\x84 naulakossa roikkuu avain, jonka avaimenper\x84ss\x84 lukee teksti \x22Saunan avain\x22, otat avaimen.")
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10);
		}
		else
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		}
		cout << endl << *teksti << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "Valitse toiminto: ";
		cin >> valikko;

		switch (valikko)
		{
		case '1':
			*tarina = 1;
			break;
		case '2':
			*teksti = "Katsot ulos ikkunoista, n\x84" "et pime\x84\x84.";
			break;
		case '3':
			cin.get(); // Luetaan enter roskiin, jos t‰t‰ ei ole niin do while loop heitt‰‰ automaatilla ulos.
			if (tavarat.unet == false) // tarkistetaan onko jo nukuttu
			{
				tavarat.unet = true; // saadaan unet parametri structiin, t‰ll‰ vaihdetaan kellonaika olohuoneessa tv:n katselua varten
				system("CLS");
				cout << "S\x84nky tuntuu mukavan pehme\x84lt\x84, nukahdat heti..." << endl;
				do //tehd‰‰n kunnes pelaaja painaa entteri‰, periaatteessa pelaaja saa kirjotella ruudulle jos tykk‰‰.
				{
					cout << "ZzZzZzZzzzz" << endl;
				} while (cin.get() != '\n');
				*teksti = "Her\x84\x84t viel\x84 enemm\x84n v\x84syneen\x84.";
			}
			else
			{
				*teksti = "Et halua nukkua enemp\x84\x84.";
			}
			break;
		case '4':
			*teksti = "S\x84ngyt ovat pehme\x84t ja mietit miksi et nukkunut niiss\x84. S\x84ngyiss\x84 ei ole mit\x84\x84n l\x94ydett\x84v\x84\x84.";
			break;
		case '5':
			if (tavarat.avain == true)
			{
				if (tavarat.saunan_avain == false)
				{
					tavarat.saunan_avain = true;
					*teksti = "Avasit komeron oven l\x94yt\x84m\x84ll\x84si avaimella, komerossa on patjoja ja vuodeliinoja, sek\x84 naulakossa roikkuu avain, jonka avaimenper\x84ss\x84 lukee teksti \x22Saunan avain\x22, otat avaimen.";
				}
				else
				{
					*teksti = "Komerossa on patjoja ja vuodeliinoja.";
				}
			}
			else
			{
				*teksti = "Komeron ovi on lukossa, tarvitset avaimen";
			}

			break;

		default:
			cout << "Virheellinen valinta" << endl;

		}
		if (*tarina == 1)
		{
			break;
		}
		else
		{
			continue;
		}

	}
	return tavarat;
}

/*
-----------------------------------------------------------------------------------------------------------
|
|
|								MAKUUHUONE
|
|
-----------------------------------------------------------------------------------------------------------
*/

H÷PER÷ Makuuhuone(int *tarina, string *teksti, H÷PER÷ tavarat)
{
	tavarat.makuuhuone = true;
	*teksti = "Saavuit makuuhuoneeseen";
	char valikko;
	for (;;)
	{
		system("CLS");
		if (tavarat.vaatteet == false)
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 9);
			cout << "Olet alasti, sinulla on kylm\x84." << endl;

		}
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		cout << "Olet makuuhuoneessa" << endl;
		cout << "Naet ikkunan it\x84\x84n, sek\x84 2 s\x84nky\x84, lipaston ja kaapiston" << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "1. Mene ovesta olohuoneeseen" << endl;
		cout << "2. Katso ikkunasta ulos" << endl;
		cout << "3. Tutki s\x84ngyt" << endl;
		cout << "4. Tutki lipasto" << endl;
		cout << "5. Tutki kaapisto" << endl;
		if (*teksti == "L\x94ysit p\x84\x84lle pantavaa, olet mukavanhaluinen ja puet itsesi pyjamaan.")
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10);
		}
		else if (*teksti == "L\x94ysit taskulampun, paristoissa tuntuu olevan viel\x84 virtaa.")
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10);
		}
		else
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		}
		cout << endl << *teksti << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "Valitse toiminto: ";
		cin >> valikko;



		switch (valikko)
		{
		case '1':
			*tarina = 1;
			break;
		case '2':
			*teksti = "Katsot ulos ikkunoista, n\x84" "et pime\x84\x84.";
			break;
		case '3':
			*teksti = "S\x84ngyt ovat pehme\x84t ja mietit miksi et nukkunut niiss\x84. S\x84ngyiss\x84 ei ole mit\x84\x84n l\x94ydett\x84v\x84\x84.";
			break;
		case '4':
			if (tavarat.taskulamppu == false)
			{
				tavarat.taskulamppu = true;
				*teksti = "L\x94ysit taskulampun, paristoissa tuntuu olevan viel\x84 virtaa.";
			}
			else
			{
				*teksti = "Lipastosta ei l\x94ydy mit\x84\x84n k\x84ytt\x94kelpoista.";
			}
			break;
		case '5':
			if (tavarat.vaatteet == false)
			{
				tavarat.vaatteet = true;
				*teksti = "L\x94ysit p\x84\x84lle pantavaa, olet mukavanhaluinen ja puet itsesi pyjamaan.";
			}
			else
			{
				*teksti = "Kaapistossa on my\x94s paljon muita vaatteita, vaihdat vaatteet.";
			}
			break;
		default:
			cout << "Virheellinen valinta" << endl;

		}
		if (*tarina == 1)
		{

			break;
		}
		else
		{
			continue;
		}
	}
	return tavarat;
}

/*
-----------------------------------------------------------------------------------------------------------
|
|
|								PIHA
|
|
-----------------------------------------------------------------------------------------------------------
*/

H÷PER÷ Piha(int *tarina, string *teksti, H÷PER÷ tavarat)
{
	tavarat.piha = true;
	*teksti = "Tulit ulos";
	char valikko;
	for (;;)
	{
		system("CLS");
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		cout << "Olet pihalla" << endl;
		cout << "N\x84" << "et saunarakennuksen ja ulkohuussin, sek\x84 p\x84\x84rakennuksen" << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "1. Tutki saunarakennusta" << endl;
		cout << "2. Tutki huussia" << endl;
		cout << "3. Tutki p\x84\x84rakennusta" << endl;
		cout << "4. Mene saunarakennukseen" << endl;
		cout << "5. Mene huussiin" << endl;
		cout << "6. Mene p\x84\x84rakennukseen" << endl;
		if (*teksti == "L\x94ysit avaimen")
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 10);
		}
		else
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		}
		cout << endl << *teksti << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "Valitse toiminto: ";
		cin >> valikko;
		


		switch (valikko)
		{
		case '1':
			*teksti = "Saunarakennuksen sein\x84maalit n\x84ytt\x84v\x84t haurailta ja se kaipaa uutta maalausta. Saunan ikkunoiden verhot ovat kiinni, olet kuulevinasi jotakin \x84\x84nt\x84 sis\x84lt\x84, mutta et ole varma tuleeko se vain p\x84\x84si sis\x84lt\x84.";
			break;
		case '2':
			if (tavarat.avain == false)
			{
				tavarat.avain = true;
				*teksti = "L\x94ysit avaimen";
			}
			else
			{
				*teksti = "Huussin katolla on kaksi sentti\x84 lunta.";
			}
			break;
		case '3':
			*teksti = "Rakennus on puinen hirsim\x94kki, joka on maalattu tumman ruskeaksi, talossa on kaksi kerrosta ja olet j\x84tt\x84nyt kaikkiin huoneisiin valot p\x84\x84lle. N\x84" "et id\x84sta l\x84nteen talon l\x84pi, koska v\x84liovi on auki.";
			break;
		case '4':
			if (tavarat.saunan_avain == true)
			{
				*tarina = 6;
				*teksti = "Avasit lukitun oven ja astuit sis\x84lle saunaan.";
				break;
			}
			else if (tavarat.avain == true)
			{
				*teksti = "L\x94yt\x84m\x84si avain, ei k\x84y t\x84h\x84n oveen.";
			}
			else
			{
				*teksti = "Saunan ovi on lukossa. Et p\x84\x84se sis\x84\x84n.";
			}
			break;
		case '5':
			*tarina = 5;
			*teksti = "Menit huussiin.";
			break;
		case '6':
			*tarina = 1;
			*teksti = "Tulit takaisin p\x84\x84rakennuksen olohuoneeseen.";
			break;
		default:
			cout << "Virheellinen valinta" << endl;

		}
		if (*tarina == 1)
		{

			break;
		}
		if (*tarina == 5)
		{

			break;
		}
		if (*tarina == 6)
		{

			break;
		}
		else
		{
			continue;
		}
	}
	return tavarat;
}

/*
-----------------------------------------------------------------------------------------------------------
|
|
|								SAUNA
|
|
-----------------------------------------------------------------------------------------------------------
*/

H÷PER÷ Sauna(int *tarina, string *teksti, H÷PER÷ tavarat)
{
	tavarat.sauna = true;
	*teksti = "Saavuit saunaan, josta l\x94ysit puolisosi yhdess\x84 lastesi kanssa joulusaunasta. Perheesi olikin ihmetellyt meinaatko saapua lainkaan, kun sanoit k\x84yv\x84si ensin sis\x84ll\x84 tekem\x84ss\x84 pari hommaa. Otat pullon kylm\x84\x84 Vichy\x84 ja liityt perheesi kanssa joulusaunan ihmeeseen. Hyv\x84\x84 joulua!";
	*tarina = 0; // annetaan p‰‰ohjelman do while looppiin arvo, mill‰ siit‰ p‰‰see ulos ja peli voi loppua.
	return tavarat;

}

/*
-----------------------------------------------------------------------------------------------------------
|
|
|								HUUSSI
|
|
-----------------------------------------------------------------------------------------------------------
*/

H÷PER÷ Huussi(int *tarina, string *teksti, H÷PER÷ tavarat)
{
	tavarat.huussi = true;
	*teksti = "Menit huussiin";
	char valikko;
	for (;;)
	{
		system("CLS");
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		cout << "Istut huussissa" << endl;
		cout << "N\x84" << "et ovi-ikkunasta pimeyteen ja l\x94yd\x84t luettavaa sek\x84 jallupullon." << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "1. Tee tarpeesi" << endl;
		cout << "2. Lue Aku Ankkaa" << endl;
		cout << "3. Lue Kodin kuvalehti" << endl;
		cout << "4. Juo jallupullo" << endl;
		cout << "5. Mene ulos" << endl;
		if (*teksti == "Istahdat p\x94nt\x94lle ja alat v\x84\x84nt\x84m\x84\x84n, kuitenkin \x84kki\x84 joudut nousemaan ja k\x84\x84ntym\x84\x84n, laitat p\x84\x84n kohti p\x94ntt\x94\x84 ja oksennat. Olosi tuntuu helpottuneelta.")
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 6);
		}
		else
		{
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		}
		cout << endl << *teksti << endl;
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);
		cout << "Valitse toiminto: ";
		cin >> valikko;



		switch (valikko)
		{
		case '1':
			*teksti = "Istahdat p\x94nt\x94lle ja alat v\x84\x84nt\x84m\x84\x84n, kuitenkin \x84kki\x84 joudut nousemaan ja k\x84\x84ntym\x84\x84n, laitat p\x84\x84n kohti p\x94ntt\x94\x84 ja oksennat. Olosi tuntuu helpottuneelta.";
			break;
		case '2':
			*teksti = "Taas on Roope laittanut Akun remontoimaan m\x94kkihuvilaa ruokapalkalla.";
			break;
		case '3':
			*teksti = "L\x94yd\x84t jutun mik\x84 kertoo saunan lukkojen vaihtamisesta kes\x84m\x94kille.";
			break;
		case '4':
			*tarina = 0; // annetaan arvo jolla p‰‰see p‰‰ohjelman do while loopista pihalle, mutta saadaan "bad ending" pelille, kts rivi 98
			*teksti = "Joit itsesi niin huonoon kuntoon, ett\x84 sammuit lopullisesti ja j\x84\x84" "dyit kylmyyteen.";
			break;
		case '5':
			*tarina = 4;
			*teksti = "Menit ulos.";
			break;
		default:
			cout << "Virheellinen valinta" << endl;
		}
		if (*tarina == 0)
		{

			break;
		}
		if (*tarina == 4)
		{

			break;
		}
		else
		{
			continue;
		}
	}
	return tavarat;
}
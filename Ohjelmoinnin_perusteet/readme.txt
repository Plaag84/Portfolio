Syksy 2018 c++ kurssin tehtävät

HARJOITUKSIA on YHTEENSÄ 25kpl.

Opiskelija palauttaa harjoitukset GitHub/Optima palvelun kautta.

Tuntiharjoitusten arviointi hyväksytty/hylätty asteikolla.

MATERIAALI:  PowerPoin -kalvot

Harjoitus 1 (vko 38)
Tee vuokaavio (=lohkokaavio), joka kuvaa miten kolme
käyttäjän antamaa lukua tulostetaan suuruusjarjestyksessä
pienimmästa suurimpaan.

Harjoitus 2 (vko 38)
Tee harjoituksen 1 kaaviosta myäs pseudokoodi.

MATERIAALI:  HelloWorld- ja kehitysympäristövideot

Harjoitus 3 (palautus vko 39)

include <iostream> 
using namespace std;
void main (void)
{
cout << "Hei maailma!";
}

Muokkaa ylla olevaa ohjelmaa niin, etta tulostat oman nimesi
ja osoitteesi naytolle allekkain.
HUOM! Nimeä tiedosto harj3a.cpp nimelle!
Muokkaa edellisestä ohjelmasta versio nimelle harj3b.cpp, jossa
nimi ja osoite tulostetaan näytälle seuraavasti:

**********************************
* *
* Etunimi 
* Sukunimi *
* *
*-------------------------------------- *
* *
* Asemakatu 7 *
* 40520 JKL *
* *
**********************************

MATERIAALI:  Luku 4 Kirjoitussäännöt

Harjoitus 4 (palautus vko 39)

Ks.  Oppikirjan (+omat) esimerkit, harj4

a) Kirjoita, tallenna ja suorita ym. ohjelma.
b) Kommentoi ylla olevan esimerkin kaikki rivit (mitä rivillä tapahtuu).
c) Muuta vakioden nimet niin, että
MAX => MINIMI
max => MAKSIMI

Muuta ohjelmaa niin, että voit tulostaa ohjelmalla jonkun seuraavat ilmoitukset riippuen syötetystä luvusta:
Summa on pienempi kuin MINIMI 
Summa on suurempi kuin MAKSIMI
Summa on MINIMIN ja MAKSIMIN välissä

MATERIAALI:  Luku 5 Tyypit, muuttujat ja vakiot sekä luku 6 Ohjelman perustoiminnot

Harjoitus 5 (palautus vko 40)

Kirjoita ohjelma, joka pyytää käyttäjältä kaksi kokonaislukua.

Ohjelma tulostaa tekstin BINGO, mikäli luvut ovat samoja.

Muussa tapauksessa ohjelma tulostaa tekstin BONGO.

Harjoitus 6 (palautus vko 40)
Kirjoita ohjelma, joka kysyy käyttäjältä lompakossa olevan rahamäärän
ja lihapiirakan hinnan.

Ohjelma tutkii, onko käyttäjällä varaa ostaa lihapiirakka. 
Jos on, ohjelma ilmoittaa, kuinka paljon lompakkoon jää vielä rahaa.
Muuten ohjelma kehottaa käyttäjää paastoamaan.

Käytä vain kahta muuttujaa. älä vähennä lompakon sisältää, ellet voi
ostaa lihapiirakkaa.

Harjoitus 7 (palautus vko 40)

Tee ohjelma, joka kysyy käyttäjältä nimen, pituuden sentteinä ja painon kiloina. 
Ohjelma laskee ja tulostaa käyttäjän ihannepainon (pituus-100). Lisäksi
ohjelma kertoo käyttäjän nykyisen painon eron kiloina verrattuna ihanne- 
painoon. Ohjelman käyttöliittymä toimii seuraavasti:

Ihannepaino

Ohjelma laskee ihannepainosi
pituutesi perusteella.

Anna nimesi > Mooses
Anna pituutesi sentteinä > 175
Anna osoitteesi > Peikkovuori 5 as 4
Anna painosi kiloina > 89


Arvoisa Mooses
Osoitteesi on Peikkovuori 5 as 4
Nykyinen painosi 89.0 kg
Ihannepainosi 75.0 kg
Erotus 14.0 kg


Käytä cin/cout/cin.get... olioita ohjelman
toteuttamiseen (c++ metodit, kirja sivu 92 - 99)

MATERIAALI:  Luku 7 Vertailu ja toistolauseet

Harjoitus 8 (palautus vko 41)
Tee ohjelma, joka tulostaa annetut kolme lukua suuruus-
järjestyksessä (pienimmästä suurimpaan) näytölle
(katso harj. 1 suunnitelma)
a) käytä kokonaislukuja
b) käytä liukulukuja (=reaalilukuja)

Harjoitus 9 (Palautus vko 41)
Tee ohjelma, joka toimii laskimena.
Käyttäjältä kysytään kaksi kokonaislukua,
jonka jälkeen ohjelma antaa valikon
laskutoimituksista. Valikko nayttaa
seuraavalta:

VALIKKO
1. Summa
2. Erotus
3. Tulo
4. Osamaara
5. Jakojaannos

Lopuksi ohjelma tulostaa valitun tuloksen naytölle.

Harjoitus 10 (Palautus vko 41)

Tee ohjelma, joka laskee syötetyistä kokonaisluvuista sekä positiivisten
että negatiivisten kokonaislukujen osuuden. Lukujen syöttä lopetetaan
syöttämällä luku 0.

Tulostus:
Syötit kokonaislukuja seuraavasti:
----------------------------------
Negatiiviset 7 kpl 70.00%
Positiiviset 3 kpl 30.00%
Yhteensä 10 kpl 100.00%

Harjoitus 11 (Palautus vko 43)
Muuta tehtävän 9 laskin-ohjelmaa niin, etta valikko nayttaa
seuraavalta:

VALIKKO
0. Lopetus
1. Summa
2. Erotus
3. Tulo
4. Osamaara
5. Jakojaannos
6. Syota uudet luvut laskemista varten

Laskimella on siis mahdollista käsitellä
useita lukupareja käyttäjän toiveiden
mukaisesti. Mita tapahtuu, jos luku2 on 0?
HUOM! goto -lauseen käyttä on KIELLETTY!!!!

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

MATERIAALI:  Luku 8 Merkkitiedon ja C -tyylisen merkkijonon käsittely, Liite B: Merkistö

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

Harjoitus 14 (Palautus vko 45)

TäSSä TEHTÄVÄSSÄ ON KÄYTETTÄVÄ C-kielen merkkitaulukoita! Taulukon määrittely on siis muotoa 

char mjono[xx];

Tee ohjelma, joka kysyy käyttäjältä 17 merkkiä
pitkän merkkijonon (ei välilyäntejä).
a) Ohjelma tulostaa merkkijonon käänteisessä järjestyksessä näytälle
(tulostus tyyppiä "cout << mjono1[4];" jne)
b) Ohjelma kääntää annetun merkkijonon toiseen
merkkijonoon ja tulostaa sen näytälle
(tulostus tyyppiä "cout << mjono2;")
c) merkkijono voi olla kuinka pitkä
tahansa (max 100 kirjainta).
Syätetyn merkkijonon pituutta ei saa
laskea millään kirjastofunktiolla
(esim. lenght tms.) Ohjelma
tutkii onko annettu merkkijono
palindromi ja ilmoittaa sen käyttäjälle.
Välilyännit jonossa ovat sallittuja.

Käyttäjä syöttää jonon: ABC_Kissa_kavelee
ohjelma tulostaa: eelevak_assiK_CBA

Harjoitus 15 (Palautus vko 45)

Tee ohjelma, joka kysyy henkilötietosi seuraavasti:
Anna (kaikki) etunimesi (merkkijono):
Anna kengannumero (kokonaisluku):
Anna sukunimi (merkkijono):
Anna koulumatka (reaaliluku):
Anna osoitteesi:
Anna postinumero:

Ohjelma tulostaa tiedot seuraavasti:
sukunimi etunimet
osoite
postinumero
kengannumero ja koulumatka

Käytä C++:n cin- ja cout-olioita ohjelman toteuttamiseen.

MATERIAALI:  Luku 9 Lisää tyypeistä

Harjoitus 16 (Palautus vko 45)
Tee ohjelma, joka kysyy henkilotietosi ja tallentaa ne tietueeseen.
Tietueeseen talletetaan seuraavat tiedot:
etunimi (merkkijono; C:n merkkitaulukko)
sukunimi (merkkijono; C:n merkkitaulukko)
koulumatka (reaaliluku)
osoite (merkkijono; C:n merkkitaulukko)
postinumero (merkkijono; C:n merkkitaulukko)
kengannumero (kokonaisluku)

Ohjelma tulostaa lopuksi tietueen tiedot naytölle.

Harjoitus 17 (Palautus vko 46)
Muokkaa edellistä ohjelmaa siten, että edellä määriteltyä tietuetyyppiä
käytetään myäs kahden muun "koululaisen" tietojen tallentamiseen.
Näiden kahden muun koululaisen tiedot alustetaan ao. muuttujien
määrittelyn yhteydessä. Ainoastaan yhden koululaisen tiedot kysytään
käyttäjältä edellisen tehtävän tapaan.

Tulosta kolmen koululaisen tiedot koulumatkan mukaisessa
suuruusjärjestyksessä (pienimmästä suurimpaan) näytälle

Harjoitus 18 (Palautus vko 46)
Tee ohjelma, joka kysyy viiden koiran nimet ja iät.
Tiedot tallennetaan tietuetaulukkoon.
a) järjestä tiedot ikä -kentän mukaan suuruusjärjestykseen
(pienimmästä suurimpaan). Ohjelma tulostaa lopuksi
jarjestetyn taulukon näytälle.
b) järjestä tiedot nimi -kentän mukaan aakkosjärjestyksessä
Ohjelma tulostaa lopuksi jarjestetyn taulukon näytolle.

Lajittelu tulee toteuttaa siten, että se toimisi samoin
myäs 50 tai 5000 koiran tapauksssa.


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

Harjoitus 20 (Palautus vko 47)



Kuten harjoitus 19, mutta toteuta kayttaen taulukkoa ja osoitinta
tiedon käsittelyyn


MATERIAALI:  Luku 10 Aliohjelmat

Harjoitus 21 (Palautus vko 48)
Muunna harjoitus 11 niin, etta käytät seuraavia aliohjelmia:

int KysyValinta(void);

-> KysyValinta paluttaa käyttäjän antaman valintanumeron (0-6)

double Summa(float luku1, int luku2);

-> Summa laskee yhteen annetut tiedot ja palauttaa summan pääohjelmaan

Harjoitus 22 (Palautus vko 49)
Tee ohjelma, joka toimii henkilörekisterinä (max 10).
Ohjelma antaa käyttäjälle seuraavan valikon:

VALIKKO
0 Lopeta
1 Lisaa henkilo
2 Nayta kaikki henkilot

Tallenna henkilöiden tiedot tietuetaulukkoon.
Tallennettavia tietoja ovat
etunimi (merkkijono)
koulumatka (liukuluku)
hatun koko (kokonaisluku)

Toteuta ensin koko ohjelma pääohjelmana. 

Tämän jälkeen lisää seuraavat aliohjelmat:
a) int Valikko(void);

b) void TulostaHenkilo(TIEDOT );
c) void TulostaKaikkiHenkilot(TIEDOT [], int lkm);
d) void LisaaHenkilo(TIEDOT [], int *lkm);

Harjoitus 23 (Palautus vko 50)
Jaa aiemmin esitetty henkilörekisteri-ohjelma omiin "osa-projekteihin" ja
otsikkotiedostoihin. Laita pääohjelma omaan tiedostoon (paa.cpp),
aliohjelmat omaan tiedostoon (ali.cpp) ja
esittelyt omaan otsikkotiedostoon (esittely.h).

Projekti tulee koostaa toimivaksi Visual Studio-
ympäristösssä.

MATERIAALI:  Luku 14 Tiedostot

Harjoitus 24 (Palautus vko 17)
Muuta harjoitusta 22 niin, etta valikko nayttaa seuraavalta:

VALIKKO
0 Lopeta
1 Lisaa henkilo
2 Nayta henkilo
3 Nayta kaikki henkilot
4 Poista henkilon tiedot
5 Tallenna tiedot tiedostoon
6 Hae tiedot tiedostosta


ja toteuta valikossa näkyvät toiminnot.

Valitse haluamasi tallennusformaatti.


MATERIAALI:  Luku 11 Dynaaminen muistinhallinta

Harjoitus 25 (Palautus vko 50)

Muuta harjoituksen 24 toiminnallisuutta niin, etta
varaat henkilötiedoille tilan dynaamisesti (max 10 hlo).
Muuta valikko alla olevan esimerkin mukaiseksi ja toteuta valikossa
näkyvät toiminnot.

VALIKKO
0 Lopeta
1 Lisaa henkilo
2 Nayta henkilo
3 Nayta kaikki henkilot
4 Poista henkilon tiedot



BONUS TEHTÄVÄT

BONUSHarjoitus 1
Tee vuokaavio (=lohkokaavio), joka kuvaa kuinka kaksi kellonaikaa
vähennetään toisistaan? Kellonajat ovat muodossa hh:mm
esim. 12:47 ja 09:36.

Tehtävässä oletetaan, että kellonajat ovat samalta päivältä.
Vinkki: Muunna molemmat kellonajat aluksi minuuteiksi.

BONUSHarjoitus 2
Tee vuokaavio (=lohkokaavio), joka kuvaa yksinkertaista
juoma-automaattia. Automaatti toimii sekä 1 euron että 2 euron
kolikoilla. Juoma maksaa 3 euroa. Rahoja voi syättää missä
järjestyksessä hyvänsä. Kun rahaa on tarpeeksi, palauttaa automaatti
mahdolliset ylimääräiset rahat sekä antaa juoman. Automaattiin ei ole
mahdollista syättää vääriä kolikoita.

ALKU
Pyydä kolikko
Syätetty kolikko on 1 euron kolikko
...
...
Anna juoma
Palauta x euroa.
LOPPU
BONUSHarjoitus 3


Tee ohjelma, joka kysyy käyttäjältä kokonaisluvun väliltä 1-9 ja
tulostaa vastauksen perusteella seuraavan kuvion (jos vastaus on 6):

1
222
33333
4444444
555555555
66666666666

Jokainen numero tulee tulostaa toistorakenten avulla erikseen lauseella:
cout << rivinro;
BONUSHarjoitus 4


Tee ohjelma, joka lukee kokonaislukuja kunnes annetaan nolla
(max 50kpl). Lopuksi syötetyt luvut tulostetaan pienimmästä
suurimpaan.
BONUSHarjoitus 5

Tee ohjelma, joka nollaa 8-alkioisen kokonaislukutaulukon
suurimman alkion sisällön. Taulukon voit alustaa luvuilla
haluamallasi tavalla. Suurimman luvun etsimisessä tulee käyttää
aliohjelmaa, joka palauttaa arvonaan suurimman alkion osoitteen.

Ohjelmasta tulee löytyä myös aliohjelma taulukon tulostamiseen.
Pääohjelman keskeinen rakenne:

...
tulosta_luvut(luvut,8);
... palauta_osoite_suurimpaan ...
tulosta_luvut(luvut,8);
...

BONUSHarjoitus 6

Tee ohjelma, joka toimii autolaskurina. Käyttäjälle näytetään
toistuvasti valikkoa:

AUTOLASKURI / Valikko:
1. Opel
2. Toyota
3. Ford
4. Tulosta autojen lukumaarat
0. Lopeta

Automerkin valinnan mukaan ao. automerkin lukumäärää lisätään
yhdellä. Valinnalla 4 näytetään kertyneet lukumäärät esim:

----------------
Opelit: 5
Toyotat: 3
Fordit: 2

------------------------

AUTOLASKURI / Valikko:
1. Opel
2. Toyota
3. Ford
4. Tulosta autojen lukumaarat
0. Lopeta


Ohjelman tulee käyttää seuraavia aliohjelmia:

void TulostaValikko();
int LueValinta(int);


void LaskeLukumaarat(Parametrilista);
void TulostaLukumaarat(Parametrilista);

BONUSHarjoitus 7

Tee ohjelma, joka toimii ENGLANTI-SUOMI -sanakirjana.
Sanaparit on tallennettu riveittäin tekstitiedostoon muodossa:

cat:kissa
dog:koira
fog:sumu
jne.


Sanat itsessään eivät voi sisältää kaksoispistettä.
Tallenna ao. tiedostoon muutamia sanapareja valmiiksi.

Toiminnot ovat:

1. Käännä
2. Lisää sanoja sanakirjaan
0. Lopeta ohjelma

* Toiminnon 1 valittua käyttäjältä kysytään:
-> Syota sana:
* Toiminnossa 2 muoto "word:sana" riittää lisättäessä
sanoja sanakirjaan.

Käyttäjä voi syöttää sanan joko englanniksi tai suomeksi.
Käännös tulee sitten toisella kielellä.
Ohjelman tulee löytää ainoastaan sellaisten sanojen käännökset,
jotka täysin vastaavat käännettävään sanaan.

VAIHTOEHTOINEN Harjoitus 22 (Palautus vko 49)  VENTTI
Tee ohjelma, joka voit käyttää jaettavien korttien tallettamisen (max 10 korttia).
Ohjelma antaa käyttäjälle seuraavan valikon:

VALIKKO
0 Lopeta
1 Ota uusi kortti
2 Nayta kaikki kortit
3 Laske ja näytä korttien summa



Tee lueteltu tyyppi
enum MAA {PA=0, HE, RI, RU};

Tallenna korttien tiedot tietuetaulukkoon.
Tallennettavia tietoja ovat
maa (lueteltu tyyppi MAA)
kortin numero (kokonaisluku1-13)
assa (0=ei ässä, 1=ässä)

Toteuta ensin koko ohjelma pääohjelmana.

Tämän jälkeen lisää seuraavat aliohjelmat:
a) int Valikko(void);
b) void TulostaKortti(KORTTI yksiKortti );
c) void TulostaKaikkiKortit(KORTTI kasi[], int korttienLkm);
d) void UusiKortti(KORTTI kasi[], int *korttienLkm);
e) tee  LaskeJaNaytaSumma(…) aliohjelma



VAIHTOEHTOINEN Harjoitus 23 (Palautus vko 49)
Jaa aiemmin esitetty ventti-ohjelma omiin "osa-projekteihin" ja
otsikkotiedostoihin. Laita pääohjelma omaan tiedostoon (paa.cpp),
aliohjelmat omaan tiedostoon (ali.cpp) ja
määritelmät omaan otsikkotiedostoon (maarittely.h).

Projekti tulee koostaa toimivaksi Visual Studio-
ympäristösssä.

VAIHTOEHTOINEN Harjoitus 24 (Palautus vko 50)
Muuta harjoitusta 22 niin, etta valikko nayttaa seuraavalta:

VALIKKO
0 Lopeta
1 Ota uusi kortti
2 Nayta kaikki kortit
3 Laske ja näytä korttien summa
4 Poista kortti kädestä
5 Tallenna tiedot tiedostoon
6 Hae tiedot tiedostosta


ja toteuta valikossa näkyvät toiminnot.

Valitse haluamasi tallennusformaatti.


VAIHTOEHTOINEN Harjoitus 25 (Palautus vko 51)

Muuta harjoituksen 24 toiminnallisuutta niin, etta
varaat kortille tilan dynaamisesti (max 52 korttia).
Muuta valikko alla olevan esimerkin mukaiseksi ja toteuta valikossa
näkyvät toiminnot.

VALIKKO
0 Lopeta
1 Ota uusi kortti
2 Nayta kaikki kortit
3 Laske ja näytä korttien summa
4 Poista kortti kädestä
5 Tallenna tiedot tiedostoon
6 Hae tiedot tiedostosta

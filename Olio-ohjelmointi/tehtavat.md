# Tehtävät

Tehtäväkohtaiset projektin solutionin/projektin nimet ja pistemäärät ovat aina näkyvissä tehtävän kuvauksen
yhteydessä. Esim. Tehtävän 1 projekti nimi on T1-Koulunumero ja pistemäärä 1. Muista noudatella
tätä määriteltyä tehtävien/projektien nimeämissääntöä aina kun luot uuden 
projektin/solutionin Visual Studiossa.

## T1-Koulunumero

* Projekti: T1-Koulunumero
* Pisteet: 1

Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan 
(pistemäärä kysytään ja ohjelma tulostaa numeron):

pisteraja | numero
--- | ---
0-1 | 0
2-3 | 1
4-5 | 2
6-7 | 3
8-9 | 4
10-11 | 5

Esimerkkitoiminta:

```
Give point limit : 8 [Enter]
School number is 4
```

## T2-Mäkihyppy

* Projekti: T2-Mäkihyppy
* Pisteet: 1

Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy 
arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että 
summasta on vähennetty pois pienin ja suurin tyylipiste.

Esimerkkitoiminta:

```
Give points: 18 [Enter]
Give points: 15 [Enter]
Give points: 20 [Enter]
Give points: 19 [Enter]
Give points: 17 [Enter]
Total points are 54
```

## T3-Kulutus

* Projekti: T3-Kulutus
* Pisteet: 1

Auton kulutus on 7½ litraa 100 kilometrin matkalla ja bensan hinta on 1,55 Euroa. 
Tee metodi, jolla voi laskea tietyn ajomatkan bensakustannukset. Pääohjelmassa 
kysytään käyttäjältä ajettu matka, sen jälkeen pääohjelma kutsuu metodia, lähettäen 
parametrina ajetun kilometrimäärän. Metodi palauttaa kuluvan bensan määrän sekä 
bensaan menevän rahan määrän ja pääohjelma näyttää ne käyttäjälle.

Esimerkkitoiminta:

```
Give distance in kilometers: 250 [Enter]
Gasoline consume is 18,75 liters and cost is 29,06 euros
```

## T4-Palindromi

* Projekti: T4-Palindromi
* Pisteet: 1

Tee ohjelma, joka kysyy käyttäjältä lauseen eli merkkijonon. Sovelluksen tulee 
ilmoittaa käyttäjälle oliko annettu merkkijono [palindromi](https://fi.wikipedia.org/wiki/Palindromi).

## T5-Nimet

* Projekti: T5-Nimet
* Pisteet: 1

Tee ohjelma, joka kysyy käyttäjältä henkilöiden nimiä, nimien syöttäminen lopetaan 
antamalla tyhjä syöte. Tämän jälkeen ohjelma kertoo montako nimeä annettiin ja 
näyttää ne aakkosjärjestyksessä.

Esimerkkitoiminta:

```
Please, give names of students. Empty input will stop the input.
Give a name: Jaska [Enter]
Give a name: Annika [Enter]
Give a name: Michael [Enter]
Give a name: [Enter]
3 names are given:
Annika
Jaska
Michael
Press any key to quit...
```

## T6-Kiuas

* Projekti: T6-Kiuas
* Pisteet: 1

Tehtävänäsi on ohjelmoida sähkökiukaan toiminta. Kiuas pitää pystyä laittamaan päälle 
ja pois, sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).

Suunnittele Kiuas-luokan ominaisuudet ja toiminnot UML-luokkakaaviona. Luokkakaavion piirtämiseen voit 
käyttää webistä löytyvää [Flow Chart Maker & Online Diagram Software](https://www.draw.io/) -palvelua 
tai esim. luokan koneille asennettua Violet-editoria. 
Voit asentaa sen kotikoneelle täältä: [Violet UML editor](http://alexdp.free.fr/violetumleditor/page.php).

Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta. 
Säädä kiuas-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, 
jotta kiuas-olion käyttäminen jää näkyville. Liitä luokkakaavion kuva projektin repoon sekä ohjelman suorite.


## T7-Pesukone

* Projekti: T7-Pesukone
* Pisteet: 1

Tehtävänäsi on ohjelmoida pyykinpesukoneen toiminta. Samoin kuin edellinen tehtävä: 
mitä ominaisuuksia ja toimintoja tekisit Pesukone-luokkaan? 

Suunnittele ja piirrä Pesukone-luokan ominaisuudet ja toiminnot UML-luokkakaaviona. Liitä kuva projektin repoon.

Toteuta Pesukone-luokan ohjelmointi sekä pääohjelma, jolla luot olion Pesukone-luokasta. 
Säädä pesukone-oliota erilaisilla arvoilla pääohjelmasta. Näytä Console.WriteLine()-tulostuslauseilla käyttäjälle pääohjelmassa pesukone-olion tilaa ja käyttöä.
Toteuta Pesukone-luokkaan muutamia erilaisia konstruktoreita (vähintään kaksi erilaista) ja alusta niitä käyttämällä oliota pääohjelmasta käsin.
Huom: pääsääntö on että luokissa ei käytetä Console-luokkaa, kaikki vuorovaikutus käyttäjälle hoidetaan pääohjelmassa. 

## T8-Televisio

* Projekti: T8-Televisio
* Pisteet: 1

Tehtävänäsi on ohjelmoida television toiminta. Samoin kuin edellinen tehtävä: 
mitä ominaisuuksia ja toimintoja tekisit Televisio-luokkaan?

Suunnittele ja piirrä Televisio-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.

Toteuta Televisio-luokan ohjelmointi sekä pääohjelma, jolla luot olion Televisio-luokasta. 
Säädä luomaasi Televsio-oliota erilaisilla arvoilla. Näytä käyttäjälle televisio-olion käyttäminen ja ominaisuudet säätämisen jälkeen.

## T9-Vehicle

* Projekti: T9-Vehicle
* Pisteet: 1

Määrittelyssä on tunnistettu, että sovelluksen tarvitsee käsitellä erilaisia ajoneuvoja, 
joita ovat: polkupyörä, moottoripyörä, henkilöauto, kuorma-auto. Luokka suunnittelussa 
on päätetty luoda Vehicle-luokka edustamaan ajoneuvoja. Ajoneuvoista on 
tunnistettu seuraavat yhteiset ominaisuudet: valmistaja, malli, nopeus ja renkaiden 
lukumäärä. Luo Vehicle-luokka seuraavien tietojen mukaisesti:

**ominaisuudet (properties)**

* Brand:string
* Model:string
* Speed:int
* Tyres:int

**toiminnot (methods)**

* ShowInfo():string, palauttaa Vehiclen valmistaja ja mallitiedot merkkijonona
* ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona, huom: ylikirjoita kantaluokan ToString()

Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jossa luodaan vähintään kaksi 
oliota Vehicle-luokasta. Luonnin jälkeen muuta olion ominaisuuksia ja 
tulosta olioiden tiedot konsolille kummallakin metodilla.

## T10-Opiskelija

* Projekti: T10-Opiskelija
* Pisteet: 1

Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle
tyypillisiä tietoja ja toimintoja. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, 
joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). 
Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta.

## T11-CD

* Projekti: T11-CD
* Pisteet: 1

Suunnittele UML-editorilla CD-luokka, joka sisältää ominaisuuksina tyypillisiä CD-levyyn kuuluvia tietoja. 
Pohdi myös mitä eri toiminnallisuuksia CD:llä voisi olla. Toteuta ainakin toiminnallisuus, 
joka palauttaa kaikkien ominaisuuksien arvot yhtenä merkkijonona (sen avulla pääohjelmassa voisi 
tulostaa kaikki CD:n tiedot). Toteuta luokalle myös ominaisuus Songs. Songs voi olla joko taulukko (Array) tai lista (List<T>) levyn kappaleista; ne voivat tässä tehtävässä olla stringejä.
 
Huom: Jos kuitenkin haluat toteuttaa levyn kappaleet olio-kokoelmana, niin tee Biisi-luokka ja toteuta CD-luokan sisälle kokoelma biisejä.

Ohjelmoi C#:lla suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olioita. 
Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tiedot biiseineen.
 
```
CD:
    -Artist: Nightwish
    -Name: Endless Forms Most Beautiful
    -Genre: Symphonic metal
    -Price: 19,9$
    Songs:
    --- Name: Shudder Before the Beautiful - 06:29
    --- Name: Weak Fantasy - 05:23
    --- Name: Elan - 04:45
    --- Name: Yours Is an Empty Hope - 05:34
    --- Name: Our Decades in the Sun - 06:37
    --- Name: My Walden - 04:38
    --- Name: Endless Forms Most Beautiful - 05:07
    --- Name: Edema Ruh - 05:15
    --- Name: Alpenglow - 04:45
    --- Name: The Eyes of Sharbat Gula - 06:03
    --- Name: The Greatest Show on Earth - 24:00  
```
 
## T12-Tank

* Projekti: T12-Tank
* Pisteet: 1

Toteuta luokka Tank, jolla on seuraavat ominaisuudet: 

* Name (string)
* Type (string)
* CrewNumber(int)
* Speed(float) 
* SpeedMax(float) 

sekä metodit 

* AccerelateTo(float)
* SlowTo(float). 

Ominaisuudet Name ja Type ovat luettavissa sekä muutettavissa ilman rajoituksia. 
Toteuta muut ominaisuudet niin, että niillä on luokan sisäinen taustamuuttuja, jota luokka käyttää. 
Ominaisuus CrewNumber on luettavissa ja asetettavissa, ja sen alkuarvo on 4. Sitä asetettaessa tarkistetaan, että annettu 
ominaisuus on sallitulla välillä: minimi on kaksi ja maksimi kuusi. 
SpeedMax-ominaisuus on pelkästään luettavissa, ja sen arvo on asetettu oletuksena 
pysyvästi arvoon 100. Speed-ominaisuuden lähtöarvo on nolla ja sitä ei voi asettaa 
suoraan, mutta sen arvon voi lukea. Speed-ominaisuuden arvoa voi muuttaa ainoastaan 
metodien AccerelateTo(float) ja SlowTo(float) kautta kuitenkin niin, että Speed
ei voi olla nollaa pienempi eikä Speedmax-arvoa suurempi; minimi on nolla ja 
maksimi 100. Jos metodeille annettu arvo ei ole sallitulla välillä, niin metodi ei muuta Speed-arvoa.

Toteuta pääohjelma TestTank, jolla testaat eri ominaisuuksien asettamista.

**Muistisääntö**: Aksessorit eivät heitä pääsääntöisesti poikkeuksia, eikä set aksessori palauta mitään.
Kysymys: Pitääkö pääohjelman ja käyttäjän metodeja kutsuessaan jotenkin tietää,
että metodi ei asettanutkaan nopeutta pyydettyyn arvoon?

## T13-Elevator

* Projekti: T13-Elevator
* Pisteet: 1

Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. 
Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja siirtämään
hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). 
Dynamon hissi voi olla vain kerroksissa 1-5; Käytä Hissi-luokassa joko  get- ja set-aksessoreita tai sopivia metodeja suojamaan olion tila.
**Huom**: Muista, että nyrkkisääntö on se että aksessorit get ja set eivät heitä poikkeuksia, eivätkä ne palauta mitään. Jos haluat että pääohjelma on tietoinen siitä, että halutun ominaisuuden muutos ei onnistu tai sitä ei voi tehdä, käytä silloin metodeja.

Esimerkkitoiminta:

```
Elevator is now in floor : 1
Give a new floor number (1-5) > 2
Elevator is now in floor : 2
Give a new floor number (1-5) > 3
Elevator is now in floor : 3
Give a new floor number (1-5) > 5
Elevator is now in floor : 5
Give a new floor number (1-5) > -1
Floor is too small!
Elevator is now in floor : 5
Give a new floor number (1-5) > 6
Floor is too big!
Elevator is now in floor : 5
Give a new floor number (1-5) > 2
Elevator is now in floor : 2
```

## T14-Amplifier

* Projekti: T14-Amplifier
* Pisteet: 1

Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan 
kontrolloida äänenvoimakkuutta välillä 0-100. Toteuta Vahvistin-luokka ja tee 
pääohjelma, jolla luot olion Vahvistin-luokasta. Säädä ja kokeile vahvistinta 
eri äänenvoimakkuuksilla. Käytä Vahvistin-luokassa joko metodeja arvojen asettamiseen tai  get- ja set-aksessoreita. 
get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori asettaa äänenvoimakkuuden arvon rajoittaen kuitenkin sen sallitulle välille.

Esimerkkitoiminta:

```
Give a new volume value (0-100) > 100
-> Amplifier volume is set to : 100
Give a new volume value (0-100) > 40
-> Amplifier volume is set to : 40
Give a new volume value (0-100) > 0
-> Amplifier volume is set to : 0
Give a new volume value (0-100) > -10
-> Too low volume - Amplifier volume is set to minimum : 0
Give a new volume value (0-100) > 200
-> Too much volume -  Amplifier volume is set to maximum : 100
Give a new volume value (0-100) > 35
-> Amplifier volume is set to : 35
```

## T15-Employees

* Projekti: T15-Employees
* Pisteet: 1

Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.

Esimerkkitoiminta: (huomaa, että Kirsi Kernelin tietoja on muutettu ohjelman suorituksessa)

```
Employee:
- Name:Kirsi Kernel Profession:Teacher Salary:1200

Boss:
- Name:Jussi Jurkka Profession:Head of Institute Salary:9000 Car:Audi Bonus:5000

Employee:
- Name:Kirsi Kernel Profession:Principal Teacher Salary:2200
```

## T16-Vehicles

* Projekti: T16-Vehicles
* Pisteet: 1

Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja. Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri. Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä. Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi. Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.

Esimerkkitoiminta:

```
Bike info 
- Name:Jopo Model:Street ModelYear:2016 Color:Blue GearWheels:False Gear Name:

Bike2 info 
- Name:Tunturi Model:StreetPower ModelYear:2010 Color:Black GearWheels:True Gear Name:Shimano

Boat info 
- Name:Suvi Model:S900 ModelYear:1990 Color:White SeatCount:3 BoatType:Rowboat

Boat2 info 
- Name:Yamaha Model:Model 1000 ModelYear:2010 Color:Yellow SeatCount:5 BoatType:Motorboat
```

## T17-Radio

* Projekti: T17-Radio
* Pisteet: 1

Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.

Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) 
ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0). Laadi luokka kannettavan radion toteutukseksi. 
Äänen voimakkuutta ja kanavaa ei voi asettaa ennen kuin radio on kytketty päälle.
Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden 
ja taajuuden arvoilla. Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.
Toteuta luokalle metodi ToString(), joka palauttaa radion kaikkien asetusten arvot.

## T18-Tavarat

* Projekti: T18-Tavarat
* Pisteet: 1

ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: kirjoja, lehtiä, 
cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... jne. 
Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) 
esiintyy ja käytä apua perintää, jos tavaroille löytyy yhteisiä ominaisuuksia.
Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. Tee myös pääohjelma, 
jossa käytät tekemiäsi luokkia ja luot olioita.

## T19-Perintä

* Projekti: T19-Perinta
* Pisteet: 1

Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää.

## T20-Nisäkäs

* Projekti: T20-Nisakas
* Pisteet: 2

Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.

Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).

Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa

Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).

Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.

## T21-Kassa

* Projekti: T21-Kassa
* Pisteet: 2

Seniorikoodari on määritellyt aiemmin valmiiksi rajapinnan. Se on seuraavanlainen:

```
public interface ITransaction {
  // interface members 
  string ShowTransaction(); 
  float GetAmount();
}
```

Toteuta pienimuotoinen Kassa-ohjelma, jolla voi suorittaa sekä Käteismaksuja että Korttimaksuja.
Luo luokat PaidWithCash ja PaidWithCard. Kumpikin luokkaa toteuttaa ITransaction-rajapinnan vaatimat metodit, 
kumpikin omalla tavallaan. Interfacessa määritelty palauttaa suomenkielisen viestin miten maksu 
suoritettiin viesti myös näyttää maksun määrän Euroina. Metodi GetAmount palauttaa maksetun määrän lukuna. 
PaidWithCash-luokalle toteuta metodi public float ShowCash(), joka kertoo paljonko rahaa kassasa on, 
eli se tallentaa itselleen kaikki kassaan laitetut rahat.

Tee Testi-ohjelma, jossa suoritat kaksi maksua kummallakin tavalla, siis käteisellä ja kortilla. 
Tee Testi-ohjelmaan myös toteutus siitä että se osaa kertoa päivän myynnin yhteensä. 

Katso oheinen esimerkkiajo:

```
Transaction to bank: charge from card 0001-0002 date 1.1.2020 amount 78.95
Transaction to bank: charge from card 0003-0004 date 1.1.2020 amount 45.65
Total money at bank account: 124.60
Paid with cash: billnumber 1 date 1.1.2020 amount 100
Paid with cash: billnumber 2 date 1.1.2020 amount 50
Total money in cash: 150
Total sales today Keskiviikko 1. Tammikuuta 2020 is 274.60 ?:
Ohjelma suoritettu onnistuneesti. Press any key to quit.
```

## T22-Rajapinta

* Projekti: T22-Rajapinta
* Pisteet: 1

Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää rajapintaa.


## T23-NewCD

* Projekti: T23-NewCD
* Pisteet: 3

Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia. CD:lla on oltava ainakin seuraavat tiedot: nimi, artisti, biisien määrä, kokonaispituus ja biisit.
CD:n sisällä olevat biisit ovat olioita Biisi-luokasta. Kustakin biisistä tallennetaan nimi ja pituus. CD:llä olevien  biisien määrää ei ole rajattu.
CD-luokan biisien määrä on vain luettavissa oleva ominaisuus, joka lasketaan CD:n biisi-olioiden lukumääränä.
CD-luokan kokonaispituus on vain luettavissa oleva ominaisuus, joka lasketaan CD:n biisi-olioiden pituuksien summana.
Ohjelmoi suunnittelemasi CD-luokka ja Biisi-luokka. Toteuta pääohjelmassa CD-olio. Tiedot CD:lle voit keksiä itse ja pääohjelma asettaa ne, niitä ei tarvitse kysyä käyttäjältä.
Tarkista huolellisella testauskella, että luokkasi varmasti osaa laskea biisien määrän ja kokonaispituuden oikein!


Esimerkkitoiminta:

```
You have a CD:
- name: Endless Forms Most Beautiful
- artist: Nightwish
- total lenght: **78min 36 sec**
- 11 songs:
  - Shudder Before the Beautiful, 6:29
  - Weak Fantasy, 5:23
  - Elan, 4:45
  - Yours Is an Empty Hope, 5:34
  - Our Decades in the Sun, 6:37
  - My Walden, 4:38
  - Endless Forms Most Beautiful, 5:07
  - Edema Ruh, 5:15
  - Alpenglow, 4:45
  - The Eyes of Sharbat Gula, 6:03
  - The Greatest Show on Earth, 24:00
```

## T24-Kortit

* Projekti: T24-Kortit
* Pisteet: 3

Toteuta luokat: Kortti/Card ja Korttipakka/CardDeck. Toteuta ohjelma, joka luo kaikki
korttipelin kortit olioina (maat: hertta, ruutu, risti ja pata; arvot: A,K,Q,J, 10,9...2, kortteja siis 52.)
valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön.

Jatkoa edelliseen. Kuinka voisit toteuttaa korttipakan sekoittamisen? 
Toteuta Korttipakka-luokalle Sekoita/Shuffle-metodi, joka sekoittaa pakan 
kortit satunnaiseen järjestykseen. Kutsua metodin toimintaa pääohjelmasta.

## T25-Jono

* Projekti: T25-Jono
* Pisteet: 1

Toteuta ratkaisu, joka [simuloi kaupan kassan asiakasvirtaa](https://gitlab.labranet.jamk.fi/TTOS0200/TTOS0200-Olio-ohjelmointi/blob/master/Img/T25-Jono.PNG). Toteuta luokka Kassajono joka käyttää jonoa eli Queue-tietorakennetta. 
Kassajono -luokalla voisi olla esimerkiksi metodit:
MeneJonoon(parametrit)
PoistuJonosta(parametrit)
ja ominaisuus:
Pituus

Voit myös suunnitella ja toteuttaa oman rajapinnan luokalle. Huom: tässä yhteydessä **rajapinta** tarkoittaa luokasta ulospäin näkyviä julkisia ominaisuuksia ja metodeja.

## T26-Auto

* Projekti: T26-Auto
* Pisteet: 1

Toteuta alla olevan määrittelyn mukaisesti kaksi luokkaa Auto- ja Rengas. Tee
luokille tarvittavat ominaisuudet ja metodit. Tee pääohjelma, jossa luot kaksi-kolme autoa, 
ja varustat ne erilaisilla renkailla. Autojen ja rengastietoja ei tarvitse kysyä käyttäjältä, 
vaan voit alustaa ne suoraan pääohjelman koodissa.

**Auto**
* +Merkki:string
* +Malli:string
* +RenkaidenLkm:int {readonly}
* +MaxRenkaidenLkm:int 
* +Renkaat:List<Rengas> {readonly}

**Rengas**
* +Valmistaja:string
* +Malli:string
* +RengasKoko:string (esim: "205/45R16")

## T27-Kulkuneuvot

* Projekti: T27-Kulkuneuvot
* Pisteet: 1

Tee Rengas-luokka (tai käytä edellisen tehtävän luokkaa), jolla on seuraavat ominaisuudet: 
Valmistaja, Malli ja Rengaskoko. Tee tämän jälkeen Kulkuneuvo-luokka muutamilla 
kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi 
Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon 
renkaat Rengas-olioina List-rakenteeseen. Tee pääohjelma, jossa luot muutamia kulkuneuvoja 
(esim. auto ja moottoripyörä) renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.

Esimerkkitoiminta:

```
Created a new vehichle Porsche model 911
Tyre Nokia added to vehicle Porsche
Tyre Nokia added to vehicle Porsche
Tyre Nokia added to vehicle Porsche
Tyre Nokia added to vehicle Porsche

Vechicle Name: Porsche Model:911
Tyres:
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16

Created a new vehichle Ducati model Diavel
Tyre MIC added to vehicle Ducati
Tyre MIC added to vehicle Ducati

Vechicle Name: Ducati Model:Diavel
Tyres:
-Name: MIC Model:Pilot TyreSize:160R17
-Name: MIC Model:Pilot TyreSize:140R16    
...
```

## T28-Liiga

* Projekti: T28-Liiga
* Pisteet: 2

Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata Liiga-joukkueen (esim JYPin tai Kalpan) pelaajia. 
Luo Pelaaja-luokka, jolla on ominaisuudet Etunimi, Sukunimi, Pelipaikka ja Numero. 
Luo myös Joukkue-luokka. Luokalla on ominaisuudet Nimi, Kotikaupunki ja Pelaajat.
Ominaisuus Pelaajat on siis lista Pelaaja-olioita. Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), 
jota konstruktori kutsuu. HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat.

## T29-LiigaLevylle

* Projekti: T29-LiigaLevylle
* Pisteet: 1

Toteuta edelliseen tehtäväön tiedostoon tallentaminen. Lue kurssin lisämateriaali: [olioiden tallentaminen levylle.]( http://ttos0200.pages.labranet.jamk.fi/olio-ohjelmointi-materiaalit/content/poikkeukset/tiedostot.html)

## T30-Jääkaappi
* Projekti: T30-Jääkaappi
* Pisteet: 1

Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy. 
Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista. 
Jääkaappi on siis olio, jolla on kokoelma erilaisia elintarvikkeita.

## T31-MiniASIO

* Projekti: T31-MiniASIO
* Pisteet: 3

Toteuteta konsolipohjainen MiniASIO-ohjelma, jolla voidaan lisätä, poistaa ja hakea 
opiskelijoiden tietoja. Luo Opiskelija-luokka, jolla on ominaisuudet Etunimi, Sukunimi, AsioID ja Ryhmä. 
AsioID on aina uniikki, yksilöllinen. Se muodostetaan ottamalla etunimen ja sukunimen ensimmäinen kirjain, sekä juokseva numero alkaan 001:sta.
Lisää rekisteriin aluksi viiden testi-oppilaan tiedot tässä järjestyksessä: Hanna Husso, Kirsi Kernell, Masa Niemi, Teppo Testaaja, Allan Aalto.

```
The first opiskelija in the miniASIO:
Hanna Husso HH001 TTV19S1
The last opiskelija in the miniASIO:
Allan Aalto AA005 TTV19SM

The all 5 students in the miniASIO:
Hanna Husso HH001 TTV19S1
Kirsi Kernel KK002 TTV19S2
Masa Niemi MN003 TTV19S3
Teppo Testaaja TT004 TTV19SM
Allan Aalto AA005 TTV19SMM

The all students in alphabetical order in the miniASIO:
Allan Aalto
Hanna Husso 
Kirsi Kernel
Masa Niemi
Teppo Testaaja

Press any key to continue...
```

Lisää sen jälkeen toiminnallisuus, jolla kysytään käyttäjältä lisättävän opiskelijan tiedot. 
Opiskelija-olio lisätään listaan, jos samalla AsioID:lle olevaa opiskelijaa ei ole vielä listassa. 
Joten toteuta tarkistus, ettei annettua AsioID:tä ole jo rekisterissä.

```
Please, give data of new Opiskelija:
AsioID: JR006
Etunimi: Jack
Sukunimi: Russell
Ryhmä: TTV19S5
Jack Russell added succesfully. There are In miniASIO now 6 students.
The all students ... etc
```

## T32-Random

* Projekti: T32-Random
* Pisteet: 4

Toteuta C#:lla ohjelma, jossa List-tietorakenteeseen lisätään satunnaisesti luotuja Person-luokan oliota 10.000 kappaletta. 
Person-luokan olion etunimessä on käytettävä satunnaisesti kirjaimia väliltä A-Z ja etunimen pituus on 4 merkkiä. Sukunimi samoin, mutta pituus on 10 merkkiä.

Ohjelman tulee tulostaa henkilöiden lisäykseen kulunut aika millisekunteina. 
Etsi tämän jälkeen tietorakenteesta 1000 satunnaista henkilöä rekisteristä etunimen perusteella. Tulosta löydettyjen henkilöiden tiedot sekä hakuun yhteensä kulunut aika millisekuntteina.

Esimerkkitoiminta:

```
List Collection:
- Adding time : xx ms
- Persons count : 10000
- Random person : BEBW TXNVCXLIHR AXDTRWTNXGI

Finding persons in collection (by firstname):
- Found person with BHWQ firstname : BHWQ CEPHQDOSKF 
- Found person with PHOX firstname : PHOX LMWDVFJRLM 
- Found person with AYHA firstname : AYHA VLYCIIBNKF 
- Found person with HUTD firstname : HUTD QWAPTJLULC 
- Found person with TICP firstname : TICP XCIFCMOTIP 
- Found person with VLBS firstname : VLBS OUMVRNWLQE 
- Found person with CYJF firstname : CYJF JFOCAQDVYS 
- Found person with BRHT firstname : BRHT HDWKDCUYPG 
- Found person with YRKR firstname : YRKR GYQEESGAEE 
- Found person with YRSN firstname : YRSN AVKYEGIIGC 
- Found person with WFCL firstname : WFCL WMAFGQBQYO 
- Found person with JCBD firstname : JCBD IJFTXHDCKH 
- Found person with UGWP firstname : UGWP LXUDEORUIB 
- Found person with OFUD firstname : OFUD JWAHWEROWG 
- Found person with XEBD firstname : XEBD FBFXRJLNUM 
- Found person with FHPR firstname : FHPR WYSGRFAIEB 
- Found person with FXTQ firstname : FXTQ MSGVBDQKNT 
- Found person with BUFG firstname : BUFG DJMAGWILTK 
- Found person with VTBR firstname : VTBR LMVRFWNVPO 
- Found person with EKGJ firstname : EKGJ CDEIFGBOAV 
- Found person with NWEO firstname : NWEO FWQOWAVVVK 
- Found person with GQSP firstname : GQSP HYMABHVUHB 
- Found person with OLTC firstname : OLTC IPVOSVDTVA 
- Found person with MDGO firstname : MDGO OQFAEJPSGQ 
- Found person with RRMM firstname : RRMM OOEPIHEHIN 
- Found person with MOBS firstname : MOBS WUGPNCDOPD 
- Found person with YVDB firstname : YVDB APJXIGNADC 

- Persons tried to fiend : 1000
- Total finding time : xx ms

Press enter key to continue...
```

Kokeile samaa Dictionary-rakenteelle, käytä avaimena etunimeä. Muista sisällyttää 
rakenteeseen 10.000 alkiota ja aloittaa satunnainen haku vasta sen jälkeen. 
Muista, että Dictonary kokoelmassa ei voi olla kahta samaa avainta.

Esimerkkitoiminta:

```
Dictionary Collection:
- Adding time : xx ms
- Persons count : 10000
- Random person : SQKP BOIYJURHIE VWDMKNJPKBG

Finding persons in collection (by firstname):
- Found person with ENGR firstname : ENGR NYHOKHXSME 
- Found person with QFQX firstname : QFQX BYTRKKAJDF 
- Found person with FAQI firstname : FAQI AJYBJIDWLL 
- Found person with JJQS firstname : JJQS WUPNIPXWHJ 
- Found person with YWSJ firstname : YWSJ MCPRUIJPOX 
- Found person with TTTF firstname : TTTF BVLGVOSHSA 
- Found person with STST firstname : STST YHIALLHQJN 
- Found person with QRJH firstname : QRJH DJDYWITDRM 
- Found person with XCOH firstname : XCOH NIQRIACAJI 
- Found person with NKNM firstname : NKNM LSQMRQAFPJ 
- Found person with REVI firstname : REVI DQVFRQQGYU 
- Found person with GVPO firstname : GVPO GQOAKJUHAH 
- Found person with IYIQ firstname : IYIQ ASAVXHKYKQ 
- Found person with VKHV firstname : VKHV DOVNHWOQDA 
- Found person with WVWN firstname : WVWN TQNBJBCLNF 
- Found person with YQPF firstname : YQPF PPOJUTJHGF 
- Found person with DGOP firstname : DGOP ANMHNUXSIS 
- Found person with MNGV firstname : MNGV UVWWOUKSPE 
- Found person with YYIB firstname : YYIB FWOSQBFANJ 
- Found person with NVVD firstname : NVVD LVFETNIVWK 
- Found person with KDNA firstname : KDNA URXQKPIISG 
- Found person with EKDE firstname : EKDE IQLPJAAWHI 
- Found person with NBLY firstname : NBLY KSXSQAANTY 
- Found person with BFSR firstname : BFSR PNCWVACIRJ 
- Found person with UNVV firstname : UNVV RYPGKOHDJG 
- Found person with VJPA firstname : VJPA CSFXJVQMOM 
- Found person with QFHP firstname : QFHP FWISPWLMET 
- Found person with DFPU firstname : DFPU TSRXGQWLQI 
- Found person with YDXM firstname : YDXM TOHSVSAEIU 
- Found person with MTWH firstname : MTWH OHFHXUGAAC 
- Found person with WUAB firstname : WUAB FCDKGECMMY 
- Found person with LATH firstname : LATH KQYLVLFONL 

- Persons tried to fiend : 1000
- Total finding time : xx ms

Press enter key to continue...
```

Mitä eroavaisuuksia havaitsit rakenteissa ja nopeuksissa?

## T33-Delegaatti

* Projekti: T33-Delegaatti
* Pisteet: 2

Tee delegaateilla ohjelma, jolla käyttäjä syöttää merkkijonon. Sen jälkeen käyttäjä voi valita yhden tai useamman toiminnon jota merkkijonolle tehdään. 
Merkkijonolle pitää pystyä tekemään seuraavat toiminnot:

* muuttaa merkkijonon kaikki kirjaimet isoiksi kirjaimiksi
* muuttaa merkkijonon kaikki kirjaimet pieniksi kirjaimiksi
* muuttaa merkkijonon Otsikko-tyyllin, eli ensimmäinen merkki isolla ja loput pienellä
* kääntää merkkijonon toistepäin eli sanasta Teppo tulee oppeT.

Eli toteuta kutakin muunnosta varten oma metodi (kaikilla metodeilla täytyy olla sama signature). Luo delegaatista instanssi ja kiinnitä siihen tarvittavat metodit. Voilá.

Esimerkkitoiminta:

```
Anna käsiteltävä merkkojono:
kissakala

Valitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla 
yhtenä merkkijonona esim '123'
1: isoiksi kirjaimiksi
2: pieniksi kirjaimiksi
3: otsikoksi
4: palindromiksi
0: lopetus

Valinta: 123

kissakala muutettu muotoon KISSAKALA
kissakala muutettu muotoon kissakala
kissakala muutettu muotoon alakassik

Valitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla 
yhtenä merkkijonona esim '123'
1: isoiksi kirjaimiksi
2: pieniksi kirjaimiksi
3: otsikoksi
4: palindromiksi
0: lopetus

Valinta: 
```

## T34-Lambda

* Projekti: T34-Lambda
* Pisteet: 3

Toteuta pienimuotoinen MyMailBook-ohjelma, jolla voit hakea ja tallentaa tuttujesi sähköposti 
(yksinkertaisuuden vuoksi oletetaan tässä että kullakin tutulla on vain yksi sähköpostiosoite). 
Luo luokka Friend, jolla on ominaisuudet Name ja Email. Tee kokoelmaluokka MailBook, 
joka alustettaessa hakee tekstitiedostosta tutut.csv ja heidän sp-osoitteensa ja tallentaa 
ne Friend-olioihin. Kokoelmaluokalla MailBook on readonly ominaisuus on Friends, joka palauttaa 
listan Friend-olioita. 

Toteuta pääohjelmaan ja/tai em. MailBook-luokkaan seuraavat toiminnot:

* ohjelman käynnistyessä lukee tiedostosta tutut ja näyttää montako nimeä sai luettua
* näyttää kaikki ystävät näytöllä
* haku, jolle annetaan ystävän nimi tai sen alkuosa. Haku hakee lambda-funktiolla kaikki ystävät, joitten nimestä löytyy etsitty merkkijono. Huomaa että haku saattaa tuottaa yhden tai useamman tuloksen.
* uuden ystävän lisääminen, ystävän tiedot täytyy myös tallentaa em. tekstitiedostoon, huom: toteuta sopiva poikkeusten käsittely

Esimerkkitoiminta:

```
Osoitekirjassa 11 nimeä:
Aku Ankka
Pelle Peloton
Matt Nickerson
Jack Russell
Cecilia Thorson
Nikke Nackerstrom
Svella Bitti
Kirsi Kernel
Joe Doe
Sven Duhfa
Kai Kersson

Anna haettavan tutun nimi tai sen osa > Sv

Svella Bitti svella@bitti.com
Sven Duhfa sven@duhfa.com

Ohjelma suoritettu onnistuneesti. Press any key to continue...
```

## T35-Laskutoimituksia

* Projekti: T35-Laskutoimituksia
* Pisteet: 2

Toteuta ArrayCalcs-niminen luokka ja sen sisälle seuraavat staattiset-metodit: Sum, Average, Min ja Max. 
Metodit ottavat parametriksi double[]-taulukon ja laskevat nimensä mukaisen laskutoimintuksen 
taulukon alkioille ja palauttavat tuloksen kutsuvalle ohjelmalle.

Toteuta pääohjelma ja esimerkiksi seuraavaa dataa sisältävä taulukko: double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; 
Kutsu pääohjelmasta ArrayCalcs-luokan staattisia laskutoimituksia tekeviä metodeja annetun taulukon arvoilla ja tulosta tulokset näyttölaitteelle.

Esimerkkitulostus:

```
Sum = 25,60
Ave = 3,66
Min = -4,50
Max = 12,00

Press enter key to continue...   
```

Toteuta solutioniin uusi yksikkötestaukseen liittyvä projekti ja testaa ArrayCalcs-luokan kaikki metodit.
Kuinka ArrayCalcs-luokan metodit toimivat, jos välität parametrina tyhjän double[]-taulukon: double[] array = { };

## T36-Ostoskärry

* Projekti: T36-Ostoskärry
* Pisteet: 2

Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta
riittää käsitellä nimi ja hinta. Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi 
List-tietorakenteeseen muutamia Product-luokan oliota. Tulosta lopuksi kokoelman sisältö.

Esimerkkitulostus:

```
Your products in shopping cart:
- product : Milk 1,4 e
- product : Bread 2,2 e
- product : Butter 3,2 e
- product : Cheese 4,2 e
There are 4 products in shopping cart.
Press enter key to continue...
```

Testaa yksikkötestauksen avulla, että ostoskärry ilmoittaa oikean määrän tuotteita. Tee ja suorita yksikkötestit 0,1,2 ja 5 tuotetta varten.


## T37-Ostokset

* Projekti: T37-Ostokset
* Pisteet: 2

Toteuta ohjelma, jossa voidaan näyttää lasku ostetuista tavaroista.

Jokaisesta ostetusta tavarasta tulee käsitellä seuraavat tiedot: nimi, hinta ja määrä. 
Toteutetun luokan tulee osata palauttaa tieto siitä paljonko ko. ostetut tavarat 
kokonaisuudessaan maksavat (hinta*määrä). Toteuta myös ToString()-metodi, 
joka palauttaa tuotteen nimen, hinnan ja määrät merkkijonona.

```
InvoiceItem
- Name : String
- Price : double
- Quantity : int
- Total == Price * Quantity : double
- ToString() : string
````

Toteuta luokka, joka pitää sisällään List-rakenteessa yllä määriteltyjä tuotteita.
Luokan tulee pystyä kertomaan myös asiakkaan nimi, paljonko "laskulla" on 
yhteensä tuotteita sekä niihin kuluva rahan määrä kokonaisuudessaan.

```
Invoice
- Customer : string (just a string, no Customer class..)
- List<InvoiceItem>
- Total ("sum of InvoiceItem Total's") : string
- PrintInvoice() ("prints invoice to screen")
```

Toteuta pääohjelma ja määrittele laskulle tavaroita ja ostajan nimi.

Esimerkkitulostus:

```
Customer Kirsi Kernel's invoice:
=================================
Milk   1,75e 1 pieces 1,75e total
Beer   5,25e 1 pieces 5,25e total
Butter 2,50e 2 pieces 5,00e total
=================================
Total: 4 pieces 12,00 euros
```



## T38-Noppa

* Projekti: T38-Noppa
* Pisteet: 2

Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla. Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen lukujen keskiarvo.

Esimerkkitulostus:

```
Dice, one test throw value is 4
```

```
How many times you want to throw a dice :  10000
Dice is now thrown 10000 times, average is 3,4853
```

Tulosta lopuksi kaikkien heitettyjen lukujen esiintymismäärät.

```
How many times you want to throw a dice :  10000

Dice is now thrown 10000 times
- average is 3,4853
- 1 count is 1726
- 2 count is 1610
- 3 count is 1705
- 4 count is 1691
- 5 count is 1580
- 6 count is 1688

Press enter key to continue...
```



## T39-Kalat

* Projekti: T39-Kalat
* Pisteet: 2

Toteuta sovellus MyFishApp, jossa voit hallita kalastukseen liittyviä tietoja.
Ohjelman pitää pystyä käsittelemään:kalastajan perustiedot (nimi, puhelinnumero), 
saadun kalan perustiedot (laji, pituus ja paino), sekä kalapaikan perustiedot (nimi ja paikka). 
Suunnittele tarvittava luokkarakenne, ja piirrä siitä UML-kaavio. Toteuta pääohjelma MyFishApp, 
jossa käyttäjä voi lisätä kalastajia ja heidän saamiansa kaloja. Tee toiminto jolla voi tulostaa
kalarekisterin sisältö eli kaikkien kalastajien saamat kaikki kalat.

Esimerkkitulostus:

```
A new fisherman added to Fish-register:
 - Fisherman: Kirsi Kernel Phone: 020-12345678

Fisher : Kirsi Kernel got a new fish
 - specie : pike 120 cm 4,5 kg
 - place: The Lake of Jyväskylä
 - location: Jyväskylä

Fisher : Kirsi Kernel got a new fish
 - specie: salmon 190 cm 13,2 kg
 - place: River Teno
 - location: The Northern edge of Finland

All fish in register:

Fisherman Kirsi Kernel has got following fish:

 - specie: pike 120 cm 4,5 kg
 - place: The Lake of Jyväskylä
 - location: Jyväskylä

 - specie: salmon 190 cm 13,2 kg
 - place: River Teno
 - location: The Northern edge of Finland

Press enter key to continue...   
```

Ja lopuksi toteuta kalarekisterille toiminto, että kalat voidaan tulostaa suuruusjärjestykessä (painavin ensin).

```
Sorted register

*** All fish in Fish-register: ***

 - Salmon 190 cm 13,2 kg
 - place: River Teno
 - location: The Northern edge of Finland
 - Fisherman: Kirsi Kernel

 - Pike 120 cm 4,5 kg
 - place: The Lake of Jyväskylä
 - location: Jyväskylä
 - Fisherman: Kirsi Kernel	 

 - Crucian carp 20 cm 0,4 kg
 - place: The Lake of Jyväskylä
 - location: Jyväskylä
 - Fisherman: Uolevi Kärppä
 
Press enter key to continue... 
```

## T40-Kuviot

* Projekti: T40-Kuviot
* Pisteet: 2

Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota (esim. Circle ja Rectangle). 
Laadi erillinen abstrakti Shape-luokka, josta muut kuviot peryityvät. 
Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja
Circumference-metodit (pinta-ala ja ympärysmitta). Peri Circle- ja Rectangle-luokat
Shape-luokasta ja toteuta Area- ja Circumference-metodit. Luo Shapes-luokka ja sen 
sisälle List-tietorakenne, jonne voit aina lisätä kuvioita. Toteuta pääohjelma,
jossa käytät Shapes-luokkaa, luo muutamia eri kuviota ja lisää ne Shapes-luokassa olevaan List-tietorakenteeseen. 

Käy pääohjelmassa lopuksi läpi Shapes-luokan List-tietorakenne ja tulosta kaikki sen sisältämät kuviot.

Esimerkkitulostus:

```
Circle Radius=1 Area=3,14 Circumference=7,28
Circle Radius=2 Area=12,57 Circumference=12,56
Circle Radius=3 Area=28,27 Circumference=18,84
Rectangle Width=10 Height=20 Area=200,00 Circumference=60,00
Rectangle Width=20 Height=30 Area=600,00 Circumference=100,00
Rectangle Width=40 Height=50 Area=2000,00 Circumference=180,00

Press enter key to continue...
```











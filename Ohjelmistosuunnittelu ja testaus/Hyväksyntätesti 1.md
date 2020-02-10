# Hyväksyntätesti 1

| | |
|:-:|:-:|
| Testitapauksen kuvaus | Kelpuutetaan asiakkaalla skenaario kohteen löytämisestä luonnosta   |
| Testitapaus ID | Test Case Id X |
| Testitapauksen suunnittelija | Kehittäjä | 
| Testitapauksen hyväksyjä: | Rahoittaja |
| Luontipvm | 20.2.2019 |
| Luokitus | Hyväksyntätesti / Acceptance Test |

**Päivityshistoria**

* versio 0.1 

**Testin kuvaus / tavoite**

* Testataan palvelu käyttäjän näkökulmasta ja viedään se käytäntöön asti

**Linkit vaatimuksiin tai muihin lähteisin**

* Vaatimus: [FUNCTIONAL-REQ-C0003]Sivusto toimii windows, linux ja mac laitteella()
* Vaatimus: [FUNCTIONAL-REQ-C0005]Tulostaminen mahdollista erilaisille paperikokoluokille A4,A5,US Letter()
* Käyttötapaus: [Käyttötapaus 1 - Asiakas löytää kohteen](usecase.md)
* Ominaisuus: [Ominaisuus 1 - Alueen löytäminen](../Ominaisuus 1.md)

**Testin alkutilanne (Pre-state)** 

* Käyttäjä avaa sivuston

**Testiaskeleet (Test Steps)**

Käyttäjä avaa sivuston pöytäkoneella, tulostaa kartan ja lähtee luontoon kartan kanssa.

Suoritetaan Use Case 1

**Testin lopputilanne (End-State)**


* Käyttäjä löytää perille vaivattomasti

**Huomioitava testin aikana**

* Yhteyssivustoon ei välttämättä ole käytettävissä alueellisten nettiyhteyksien toimivuudesta riippuen



**Testin "tuomio"/tulos (Pass/Fail Criteria)**


* PASS ehto: Käyttäjä löytää alueen ja se vastaa karttaa ? 
* FAIL ehto: Käyttäjä ei löydä perille annetuilla materiaaleilla tai tiedot ovat virheellisiä tai alueet aidattuja ?

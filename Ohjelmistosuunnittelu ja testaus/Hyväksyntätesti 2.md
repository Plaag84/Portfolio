# Hyväksyntätesti 2

| | |
|:-:|:-:|
| Testitapauksen kuvaus | Kelpuutetaan asiakkaalla skenaario kohteen lisäämisestä palveluun   |
| Testitapaus ID | Test Case Id Y |
| Testitapauksen suunnittelija | Kehittäjä | 
| Testitapauksen hyväksyjä: | Rahoittaja |
| Luontipvm | 20.2.2019 |
| Luokitus | Hyväksyntätesti / Acceptance Test |

**Päivityshistoria**

* versio 0.1 

**Testin kuvaus / tavoite**

* Testataan palvelu alueomistajan näkökulmasta ja viedään se käytäntöön asti

**Linkit vaatimuksiin tai muihin lähteisin**

* Vaatimus: [FUNCTIONAL-REQ-C0013]Alueen omistaja voi ilmoittaa omistamansa alueen palvelun ylläpitäjälle()
* Käyttötapaus: [Käyttötapaus 2 - Alueen omistaja ilmoittaa alueen](usecase2.md)
* Ominaisuus: [Ominaisuus 2 - Alueen ilmoittaminen](../Ominaisuus 2.md)

**Testin alkutilanne (Pre-state)** 

* Alueen omistaja omistaa alueen ja haluaa vapauttaa sen palvelun käyttöön

**Testiaskeleet (Test Steps)**

Alueen omistaja avaa sivuston ja haluaa ilmoittaa alueensa käytettäväksi palvelun käyttäjiä varten

Suoritetaan Use Case 2

**Testin lopputilanne (End-State)**


* Ylläpitäjä lisää alueen sivustolle

**Huomioitava testin aikana**

* Alueen tulee olla oikein merkattu ja täten hyväksyttää alueen omistajalla ennen palveluun lisäämistä



**Testin "tuomio"/tulos (Pass/Fail Criteria)**


* PASS ehto: Ylläpitäjä onnistuneesti lisää alueen palveluun
* FAIL ehto: Ylläpitäjä ei onnistu rajaamaan tai lisäämään palveluun aluetta oikein

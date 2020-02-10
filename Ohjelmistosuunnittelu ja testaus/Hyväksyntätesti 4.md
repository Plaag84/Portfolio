| | |
|:-:|:-:|
| Testitapauksen kuvaus | Testataan offline näkymän tallentamista |
| Testitapaus ID | Test Case Id Q |
| Testitapauksen suunnittelija | Kehittäjä | 
| Testitapauksen hyväksyjä: | Rahoittaja |
| Luontipvm | 06.03.2019 |
| Luokitus | Hyväksyntätesti / Acceptance Test |

**Päivityshistoria**

* versio 0.1 

**Testin kuvaus / tavoite**

* Testataan offline näkymän tallentamista

**Linkit vaatimuksiin tai muihin lähteisin**

* Vaatimus: [FUNCTIONAL-REQ-C0006 - Näkymän tallentaminen toimii kaikissa laitteissa](02-vaatimusmaarittely/vaatimusmaarittely.md#palveluun-liittyvät-tärkeimmät-toiminnalliset-vaatimukset-functional-requirements) 
* Käyttötapaus: [Use Case 1](usecase.md) 
* Ominaisuus: [Offline näkymän tallentaminen](02-vaatimusmaarittely/vaatimusmaarittely.md#tärkeimmät-tunnistetut-ominaisuudetpiirteet-features) 

**Testin alkutilanne (Pre-state)** 

* Käyttäjä on valinnut kohteen

**Testiaskeleet (Test Steps)**


1. Käyttäjä zoomaa halutun näkymän
2. Käyttäjä painaa kuvan tallennusnappia
3. Käyttäjä valitsee tallenusmuodon
4. Käyttäjä saa tallenteen halumanaan tiedostona
5. Käyttäjä on tyytyväinen tiedostoon
6. Käyttäjä sulkee palvelun


**Testin lopputilanne (End-State)**

* Käyttäjä voi lähteä kohteeseen tallenetun näkymän kanssa tai avata näkymän myöhemmin kuvana missä tahansa

**Huomioitava testin aikana**

* Tallennetun näkymän tulee olla samanlainen kuin näytöllä
* Tallennusnäkymä pitää olla tallennettavissa yleisimmin tuettuihin formaatteihin


**Testin "tuomio"/tulos (Pass/Fail Criteria)**


* PASS Näytön tallenne tulee ilman ylimääräisiä asioita
* FAIL Näytön tallenne ei näytä samalta kuin näkymä ruudulla tai sinne tulee ylimääräisiä valikoita tms. mukaan



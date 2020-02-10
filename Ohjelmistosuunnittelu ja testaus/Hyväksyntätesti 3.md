| | |
|:-:|:-:|
| Testitapauksen kuvaus | Testataan tulostustoimintoa |
| Testitapaus ID | Test Case Id Z |
| Testitapauksen suunnittelija | Kehittäjä | 
| Testitapauksen hyväksyjä: | Rahoittaja |
| Luontipvm | 06.03.2019 |
| Luokitus | Hyväksyntätesti / Acceptance Test |

**Päivityshistoria**

* versio 0.1 

**Testin kuvaus / tavoite**

* Testataan tulostamispalvelu käyttäjän näkökulmasta ainakin kahdella erilaisella tietokoneella ja molemmilla koneilla kahta erilaista paperikokoa

**Linkit vaatimuksiin tai muihin lähteisin**

* Vaatimus: [FUNCTIONAL-REQ-C0004 - Sivuston tulostaminen skaalautuu tulostomille näkymän mukaisesti](02-vaatimusmaarittely/vaatimusmaarittely.md#palveluun-liittyvät-tärkeimmät-toiminnalliset-vaatimukset-functional-requirements) 
* Käyttötapaus: [Use Case 1](usecase.md) 
* Ominaisuus: [Tulostaminen](02-vaatimusmaarittely/vaatimusmaarittely.md#tärkeimmät-tunnistetut-ominaisuudetpiirteet-features) 

**Testin alkutilanne (Pre-state)** 

* Käyttäjä avaa sivuston

**Testiaskeleet (Test Steps)**


1. Käyttäjä valitsee kohteen
2. Käyttäjä zoomaa halutun näkymän
3. Käyttäjä painaa tulostusnappia
4. Käyttäjä valitsee paperinkoon
5. Käyttäjä saa tulosteen
6. Käyttäjä on tyytyväinen tulosteeseen
7. Käyttäjä sulkee palvelun


**Testin lopputilanne (End-State)**

* Käyttäjä voi lähteä kohteeseen tulostetun kartan kanssa

**Huomioitava testin aikana**

* Tulostusnäkymän on vastattava näkymää ruudulla
* Tulostuksen pitää skaalautua paperikoolle kuin paperikoolle


**Testin "tuomio"/tulos (Pass/Fail Criteria)**


* PASS Tuloste tulee ilman ylimääräisiä asioita
* FAIL Tuloste ei näytä samalta kuin näkymä ruudulla tai sinne tulee ylimääräisiä valikoita tms. mukaan



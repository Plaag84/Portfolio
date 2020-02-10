| | |
|:-:|:-:|
| Testitapauksen kuvaus | Testataan mobiilikäyttöisyys |
| Testitapaus ID | Test Case Id W |
| Testitapauksen suunnittelija | Kehittäjä | 
| Testitapauksen hyväksyjä: | Rahoittaja |
| Luontipvm | 06.03.2019 |
| Luokitus | Hyväksyntätesti / Acceptance Test |

**Päivityshistoria**

* versio 0.1 

**Testin kuvaus / tavoite**

* Testataaan mobiilikäyttöisyys ja tuki mobiililaitteille

**Linkit vaatimuksiin tai muihin lähteisin**

* Vaatimus: [FUNCTIONAL-REQ-C0001 - Sivusto toimii android mobiililaitteella](02-vaatimusmaarittely/vaatimusmaarittely.md#palveluun-liittyvät-tärkeimmät-toiminnalliset-vaatimukset-functional-requirements) 
* Vaatimus: [FUNCTIONAL-REQ-C0002 - Sivusto toimii ios mobiililaitteella](02-vaatimusmaarittely/vaatimusmaarittely.md#palveluun-liittyvät-tärkeimmät-toiminnalliset-vaatimukset-functional-requirements) 
* Käyttötapaus: [Use Case 1](usecase.md) 
* Ominaisuus: [Mobiilituki](02-vaatimusmaarittely/vaatimusmaarittely.md#tärkeimmät-tunnistetut-ominaisuudetpiirteet-features) 

**Testin alkutilanne (Pre-state)** 

* Käyttäjä avaa puhelimen selaimella

**Testiaskeleet (Test Steps)**


1. Käyttäjä avaa selaimella sivuston
2. Käyttäjälle tulee ilmoitus mobiiliversiosta ja mahdollisuudesta ladata ohjelmiston
3.1 Käyttäjä jatkaa samassa näkymässä
3.2 Käyttäjä valitsee jatkaa mobiiliversiossa
3.3 Käyttäjä valitsee ohjelmistolatauksen


**Testin lopputilanne (End-State)**

* Käyttäjä voi käyttää mobiiliystävällistä versiota

**Huomioitava testin aikana**

* Jos alkuperäinen huomautus menee ohi niin näkymää voi vaihtaa myöhemminkin


**Testin "tuomio"/tulos (Pass/Fail Criteria)**


* PASS Sivusto tunnistaa mobiililaitteen
* FAIL Sivusto ei tunnista mobiililaitetta, eikä osaa tarjota muuta näkymää



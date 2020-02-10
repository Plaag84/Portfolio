# ID: UseCase 01

## Käyttötapauksennimi: Asiakas löytää kohteen

Osa-alue: Valikko

Toimijat: Asiakas

Askeleet:

* 1. Asiakas haluaa tutkia kohdetta
* 2. Asiakas valitsee kohteen kartalta
* 3. Asiakas saa tietää mitä lupia tarvitaan
* 4. Asiakas löytää linkin takaa lisätietoja
* 5. Asiakkaalla on jo lupa tai asiakas hankkii luvan lupapalvelusta
* 6. Asiakas tulostaa kartan tiedot
* 7. Asiakas matkustaa kohteeseen

Poikkeukset:

6. Kartta on päivittymätön ja siitä ei ole tiedotettu ylläpidolle

Huomioitavaa:

Kohteiden tarjoajien täytyy itse varmistaa, että palvelulla on ajankohtaiset tiedot alueista.

```plantuml
left to right direction
actor Käyttäjä
Käyttäjä -- (Alueen löytäminen)
```
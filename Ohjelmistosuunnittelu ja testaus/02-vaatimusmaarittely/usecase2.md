# ID: UseCase 02

## Käyttötapauksennimi: Alueen omistaja ilmoittaa alueen

Osa-alue: Yhteydenotto ylläpitoon

Toimijat: Alueen hallitsija

Askeleet:

* 1. Asiakas haluaa tuoda karttapalveluun oman kalastus tai metsästysalueensa
* 2. Asiakas ilmoittaa kohteen koordinaatit
* 3. Asiakas todentaa omistussuhteensa alueeseen
* 4. Asiakas jää odottamaan vahvistusta ylläpidolta
* 5. Ylläpito lähettää asiakkaalle kuvan varmistukseksi
* 6. Asiakas vahvistaa alueen
* 7. Ylläpito lisää alueen sivustolle

Poikkeukset:

5. Ylläpito ei saa vastausta, tapaus jätetään lisäämättä

Huomioitavaa:

Kohteiden tarjoajien tulee varmistaa, että alueen reunukset

```plantuml
left to right direction
actor Alueenomistaja
Alueenomistaja -- (Alueenlisäys)
```

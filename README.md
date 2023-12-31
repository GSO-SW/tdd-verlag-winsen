# Verlag
Ein bekannter Kölner Verlag plant die Neugestaltung von einigen hausintern genutzten Softwareprodukten. Zahlreiche IT-Unternehmen haben sich um diese Gelegenheit beworben und hoffen, den Auftrag zu erhalten.

Um die verschiedenen Bewerber auf ihre Eignung zu testen, verteilt der Verlag einige UserStories, die typische Anwendungsfälle beschreiben.

**Bearbeiten Sie die folgenden Aufträge entsprechend dem TDD-Paradigma:**

## Auf Basis von UnitTests entwickeln
Für die erste UserStory wurden bereits Testfälle entworfen. 


1. Als Verlagsmitarbeiter möchte ich die Bücher unseres Verlages speichern können.
    - Jedes Buch hat einen Autor, einen Titel und eine Auflage.
    - Wenn keine Auflage angegeben wird, handelt es sich um die erste Auflage.
    - Alle Angaben, außer dem Titel, sollen verändert werden können.
    - Für den Autor sollen nur sinnvolle Eingaben möglich sein.

## UnitTests entwerfern
Entwerfen Sie – dem TDD-Paradigma folgendend - geeignete Testmethoden, um die nachfolgenden UserStories abzubilden!

2. Als Verlagsmitarbeiter möchte ich die Bücher um eine ISBN-Nummer ergänzen können.
    - Für alle Bücher soll eine ISBN eingegeben und abgefragt werden können. Z.B.: "978-3-431-07055-2" 
    - Aus der ISBN ISBN13 errechnen lassen. Z.B.: ISBN = "978-3-431-07055-2" --> ISBN13 = 9783431070552
    - Wenn die ISBN ohne Prüfziffer eingegeben wird, soll diese automatisch ergänzt werden. Z.B.: ISBN = "978-3-431-07055" --> ISBN13 = 9783431070552
    - Aus der ISBN soll die ISBN10 errechnet werden können. Z.B.: ISBN = "978-3-431-07055-2" --> ISBN10 = 3431070558

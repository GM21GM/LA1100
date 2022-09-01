# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Giuliano Martullo

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Programm erstellen, welches eine Zahl von 1-100 generiert, man muss dann diese Zahl erraten, zur Hilfe wird einem nach dem Versuch gesagt, ob die Zahl grösser oder kleiner ist.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      Muss       | F     | Als Spieler möchte ich, dass eine Zufällige Zahl vom Computer generiert wird, damit ich diese daraufhin erraten kann          |
| 2    |      Muss       |  F    | Spieler möchte ich, dass eine Zahl eingegeben werden kann damit damit ich das Spiel spielen kann                              |
| 3    |      Muss       |   F   |Als Spieler möchte ich nach meinem Versuch einen Hinweis erhalten ob ich richtig lag, damit ich weiss, dass ich gewonnen habe  |
| 4     |     Muss        | F     | Als Spieler möchte ich, nach einem Fehlversuch einen Hinweis erhalten ob die Zahl kleiner oder grösser ist, damit das Spiel schneller geht
|5     |      Muss       |   F   | Als Spieler möchte ich, wenn ich die Zahl erraten habe angezeigt bekommen wie viele Versuche ich gebraucht habe, damit ich meine Versuche vergleichen kann
|6     |      Muss       |   F   |Als Spieler möchte ich eine Fehlermeldung bekommen falls meine Zahl nicht den Vorgaben entspricht, damit das Spiel funktioniert|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Zufallsgenerator erstellt haben            | Spiel Starten soll gedrückt werden        |   Zufallszahl 1-100                |
|  2.1    | Code geschrieben haben             |  Zahl eingeben Enter drücken       |  Zahl wird aufgenommen und mit Geheimzahl verglichen                |
|  3.1    |  Geheimzahl steht fest           |   Falsche Zahl erraten      |  Dein Versuch war korrekt/inkorrekt                 |
|   4.1   | Code geschrieben haben             | Falsche Zahl eingegeben haben        |  Die Zahl ist kleiner/grösser                 |
|   5.1   |  Spiel beendet            | Korrekte Zahl eingegeben        |  Du hast X Versuche gebraucht                 |
|   6.1   |   Definiert was die Regeln sind            |    Eingabe entspricht nicht den Regeln      |  Falsche Eingabe, Eingabe muss Ziffer von 1-100 entsprechen   |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![Hauptprogramm 1](https://user-images.githubusercontent.com/111045891/186598653-397bcc48-495a-44a3-8346-3bbf7018a558.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 1.9.22|  Martullo | Code schreiben, der eine zufallgenerierte Zahl von 1-100 generiert             |  2 *  45 min |
| 2.A  | 1.9.22|  Martullo | Code schreiben, welcher es ermöglich eine Zahl von 1-100 einzugeben            |       45 min |
| 3.A  | 1.9.22|  Martullo | Code schreiben, der nach dem Raten, verrät ob die Zahl richtig erraten wurde   | 2 *   45 min |
| 3.B  | 8.9.22|  Martullo | Code schreiben, der nach falschem Raten ausgibt, dass es nicht richtig war     |        45 min|
| 4.A  | 8.9.22|  Martullo | Code schreiben, der nach falschem Raten ausgibt, ob die Zahl kleiner ist       |        45 min|
| 4.B  | 8.9.22| Martullo  | Code schreiben, der nach falschem Raten ausgibt, ob die Zahl grösser ist       |        45 min|
|5.A   | 8.9.22| Martullo  | Code schreiben, der nach richtigem erraten die Anzahl Versuche angibt          |        45 min|
|6.A   | 15.9.22| Martullo | Code schreiben, der es nur ermöglicht Ziffern von 1-100 einzugeben             |        45 min|
|6.B   | 15.9.22| Martullo | Code schreiben, der eine Fehlermeldung anzeigt bei falschen Eingaben           |        45 min|
|Total: |11 Lektionen



## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   1.9.22    | Martullo          |  90 Min             | 30 Min                  |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

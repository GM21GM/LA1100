# Lern-Bericht
Giuliano Martullo

## Einleitung

Im Projekt LA1100 musste ich einen Numberguesser programmieren.

## Was habe ich gelernt?

Während dem Projekt habe ich gelernt wie man Switch-Case benutz.

## Beschreibung


Anfangs habe ich noch nicht gewusst was Switch-Case war, das hat mir meine Arbeit erschwert, da ich verschiedene Befehle probiert habe, diese bei mir aber 
nicht funktionierten. Als ich dann aber Switch-Case kennengelernt habe, habe ich es direkt in mein Projekt implementiert. Ich habe es benutzt um die Ausgabe,
dass die Eingabe ungültig ist auszugeben.
```csharp
switch (guess)
{
    case int n when (guess < 0):
    case int h when (guess > 100):
        Console.WriteLine("Ungültige Eingabe nur Ziffern von 1-100 sind gültig. Probiers nochmal!");
        guess = Convert.ToInt32(Console.ReadLine());
        break;
}
```
![image](https://user-images.githubusercontent.com/111045891/191696986-fdd46b2e-ab61-4385-8ae1-f6dd7460d32c.png)


## Verifikation
Text: Mein Vorgang, bevor und nachdem ich Switch-Case gekannt habe.

Code: Ausschnit aus meinem Programm in dem ich Switch-Case angewendet habe.

Bild: So sieht, das Switch-Case beim Abspielen des Programms aus.

# Reflexion zum Arbeitsprozess
Was gut lief:

Ich habe während des ganzen Projektes, motiviert und zielstrebig an meinen Aufgaben gearbeitet.

Was nicht so gut lief:

Ich habe im Vergleich zu an der BBB, zuhause nur das Nötige gemacht, also nur meine Tagesaufgaben. Wenn ich dies nicht gemacht hätte, hätte ich mein Programm 
vielseitiger gestalten können.

**VBV**: 
Beim nächsten Projekt werde ich zu Hause, die volle Zeit ausnutzen, damit mein Endprodukt besser wird.








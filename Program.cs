using System.Diagnostics.CodeAnalysis;

int randomN = new Random().Next(1, 99);
int guess = 0;
int versuche = 0;


Console.WriteLine("Ich habe mir eine Zahl von 1-99 ausgedacht kannst du sie erraten?");
guess = Convert.ToInt32(Console.ReadLine());
versuche++;

switch (guess)
{
    case int n when (guess < 0):
    case int h when (guess > 100):
        Console.WriteLine("Ungültige Eingabe nur Ziffern von 1-100 sind gültig. Probiers nochmal!");
        guess = Convert.ToInt32(Console.ReadLine());
        break;
}
    


    while (guess != randomN)
    do
    {

        if (guess > randomN && guess <= 99)
        {
            Console.WriteLine("Du hast zu hoch geraten, probiers mal mit einer tieferen Zahl!");
            guess = Convert.ToInt32(Console.ReadLine());
            versuche++;
        }
        if (guess < randomN)
        {
            Console.WriteLine("Du hast zu tief geraten, probiers mal mit einer höheren Zahl!");
            guess = Convert.ToInt32(Console.ReadLine());
            versuche++;
        }
        if (guess == randomN)
        {
            Console.WriteLine("Glückwunsch, du hast die Geheimzahl in " + versuche + " Versuchen erraten!");
            versuche++;
        }
    } while (guess == 2093);










Random random = new Random();
int Siffran = random.Next(1, 101);
int Gisning = -1;

Console.WriteLine("Du ska gissa rätt siffra mellan 1 och 100.");

while (Gisning != Siffran)
{
    Console.Write("Skriv in din gisning, Lycka till! ");
    
    bool isValidInput = int.TryParse(Console.ReadLine(), out Gisning);

    if (!isValidInput)
    {
        Console.WriteLine("Det var inte rätt siffra");
        continue;
    }

    if (Gisning < Siffran)
    {
        Console.WriteLine("Din gisning var för låg, försök igen");
    }
    else if (Gisning > Siffran)
    {
        Console.WriteLine("Din gisning var för hög, försök igen");
    }
    else
    {
        Console.WriteLine("Grattis, Du gissade rätt! Nu kan du få en puss");
    }
}
Console.ReadLine();
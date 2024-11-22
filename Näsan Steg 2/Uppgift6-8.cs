List<string> cities = new List<string>();

string city;
while (true)
{
    Console.Write("Skriv en Stad eller skriv 'stäng' för att stänga programmet: ");
    city = Console.ReadLine();

    if (city.ToLower() == "stäng")
    {
        break;
    }

    cities.Add(city);
    Console.WriteLine("\nStäderna du har skrivit in är:");
    foreach (string c in cities)
    {
        Console.WriteLine(c);
    }
}


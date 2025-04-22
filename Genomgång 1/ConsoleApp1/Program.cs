int age = 0;
string ageS = "";
ageS = Console.ReadLine();
int.TryParse(ageS, out age);

if (age > 15 && age < 18)
{
    Console.WriteLine("Du får inte köra bil, bara A-Traktor");
}

Console.ReadLine();

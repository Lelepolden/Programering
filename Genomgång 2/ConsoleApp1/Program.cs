
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;

Console.WriteLine("Hur många investerare vill du prata med?");
int resultat = 0;
while (resultat == 0    )
{
    string choice = Console.ReadLine();
    int.TryParse(choice, out resultat);
    if (resultat == 0)
    {
        Console.WriteLine("Nej nej, dumsnut. Skriv en siffra");
    }
}
List<Investor> investors = new();

for (int i = 0; i < resultat; i++)
{
    int chance = Random.Shared.Next(2);
    if (chance == 0)
    {
        investors.Add(new GreedyInvestor());
    }
    else 
    {
        investors.Add(new VainInvestor());
    }
    }

   






Console.ReadLine();
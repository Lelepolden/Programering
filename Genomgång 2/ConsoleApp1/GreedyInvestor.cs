public class GreedyInvestor : Investor
{
    public GreedyInvestor()
    {
        Greed = 10;
        Vanity = 2;

        Money = Random.Shared.Next(50); 
    }
}
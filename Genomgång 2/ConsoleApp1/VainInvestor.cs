public class VainInvestor : Investor
{
    public VainInvestor()
    {
        Greed = 2;
        Vanity = 10;

        Money = Random.Shared.Next(50);
    }
}

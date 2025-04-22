public class Investor
{
    public int Money;
    public int Vanity;
    public int Greed;
    public bool HasBeenApproached;

    public int Flatter()
    {
        int attempt = Random.Shared.Next(10);
        if (attempt < Vanity)
        {
            return Random.Shared.Next(1, 11);
        }

        return 0;
    }

    public int Entice()
    {
        int attempt = Random.Shared.Next(10);
        if (attempt < Greed)
        {
            return Random.Shared.Next(1,- 11);
        }
        
        return 0;
    }
}
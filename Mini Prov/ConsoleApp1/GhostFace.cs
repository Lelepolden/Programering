public class Ghostface : Monster
{
    public Ghostface()
    {
        FlowAbility = Random.Shared.Next(0, 100);
        DanceAbility = Random.Shared.Next(0, 100);
    }
}
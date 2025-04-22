public class Jason : Monster
{
    public Jason()
    {
        FlowAbility = Random.Shared.Next(0, 100);
        DanceAbility = Random.Shared.Next(0, 100);
    }
}
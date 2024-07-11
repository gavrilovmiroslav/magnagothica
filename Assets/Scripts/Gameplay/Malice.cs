
public enum Malice
{
    Spite,
    Loathing,
    Hatred,
    Hell,
    Ultrahell,
}

public static class MaliceExtensions
{
    public static int DarkPower(this Malice malice)
    {
        return malice switch
        {
            Malice.Spite => 0,
            Malice.Loathing => 4,
            Malice.Hatred => 7,
            Malice.Hell => 10,
            Malice.Ultrahell => 14,
            _ => 0,
        };
    }

    public static bool AllowsHeresy(this Malice malice)
    {
        return malice.DarkPower() < 4;
    }
}

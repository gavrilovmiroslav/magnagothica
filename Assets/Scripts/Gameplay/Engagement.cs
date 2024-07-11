
public enum Engagement
{
    Two1v1,
    Four2v2,
    FourFFA,
}

public static class EngagementExtensions
{
    public static int PlayerCount(this Engagement e)
    {
        return e switch
        {
            Engagement.Two1v1 => 2,
            Engagement.Four2v2 => 4,
            Engagement.FourFFA => 4,
            _ => 0,
        };
    }

    public static int SideCount(this Engagement e)
    {
        return e switch
        {
            Engagement.Two1v1 => 2,
            Engagement.Four2v2 => 2,
            Engagement.FourFFA => 4,
            _ => 0,
        };
    }
}
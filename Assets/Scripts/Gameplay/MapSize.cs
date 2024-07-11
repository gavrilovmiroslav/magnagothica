
public enum MapSize
{
    Sized6x6,
    Sized8x8,
    Sized10x10,
}

public static class MapSizeExtensions
{
    public static int AsInt(this MapSize size)
    {
        return size switch
        {
            MapSize.Sized6x6 => 6,
            MapSize.Sized8x8 => 8,
            MapSize.Sized10x10 => 10,
            _ => 0,
        };
    }
}
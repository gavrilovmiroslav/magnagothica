
public enum UnitType
{
    Thrall,
    Scion,
    Freak,
    Horror,
    Hunter,
    Tyrant,
}

public static class UnitTypeExtensions
{
    public static int MaxInMass(this UnitType ut)
    {
        return ut switch
        {
            UnitType.Thrall => int.MaxValue,
            UnitType.Scion => 3,
            UnitType.Freak => 2,
            UnitType.Horror => 2,
            UnitType.Hunter => 2,
            UnitType.Tyrant => 1,
            _ => 0,
        };
    }
}
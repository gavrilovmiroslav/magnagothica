
public class GameMode
{
    public string Name { get; set; } = "Duel";
    public string Description { get; set; } = "A 1v1 match";
    public Malice Malice { get; set; } = Malice.Spite;
    public bool Heresy { get; set; } = false;
    public MapSize MapSize { get; set; } = MapSize.Sized8x8;
    public Engagement Engagement { get; set; } = Engagement.Two1v1;
    public Deployment Deployment { get; set; } = Deployment.ChooseOppositeSides;
    public int SlotLimit { get; set; } = 4;
    public VictoryCondition Victory { get; set; } = VictoryCondition.Murder;
}

using System.Collections.Generic;

public class Unit
{
    public string Name { get; set; }
    public MajorHouse MajorHouse { get; set; }
    public UnitType UnitType { get; set; }
    public int MovementValue { get; set; }
    public int HitPoints { get; set; }
    public int Defense { get; set; }
    public ArmorType Armor { get; set; }
    public IEnumerable<UnitTrait> Traits { get; set; }
    public IEnumerable<UnitAbility> Abilities { get; set; }
    public IEnumerable<UnitTrait> Upgrades { get; set; }
}
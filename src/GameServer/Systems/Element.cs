using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems
{
    public class Element
    {
        public readonly ElementType Type;
        public readonly int TeamResonanceId;
        public readonly FightProperty CurEnergyProp;
        public readonly FightProperty MaxEnergyProp;
        public readonly int DepotValue;
        public readonly int ConfigHash;
    }

    public class None : Element
    {
        public new readonly ElementType Type = ElementType.None;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
    }

    public class Fire : Element
    {
        public new readonly ElementType Type = ElementType.Fire;
        public new readonly int TeamResonanceId = 10101;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
        public new readonly int DepotValue = 2;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_Fire_Lv2");
    }

    public class Water : Element
    {
        public new readonly ElementType Type = ElementType.Water;
        public new readonly int TeamResonanceId = 10201;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_WATER_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_WATER_ENERGY;
        public new readonly int DepotValue = 3;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_Water_Lv2");
    }
    public class Wind : Element
    {
        public new readonly ElementType Type = ElementType.Wind;
        public new readonly int TeamResonanceId = 10301;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_WIND_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_WIND_ENERGY;
        public new readonly int DepotValue = 4;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_Wind_Lv2");
    }
    public class Ice : Element
    {
        public new readonly ElementType Type = ElementType.Ice;
        public new readonly int TeamResonanceId = 10601;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ICE_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ICE_ENERGY;
        public new readonly int DepotValue = 5;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_Ice_Lv2");
    }
    public class Rock : Element
    {
        public new readonly ElementType Type = ElementType.Rock;
        public new readonly int TeamResonanceId = 10701;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ROCK_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ROCK_ENERGY;
        public new readonly int DepotValue = 6;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_Rock_Lv2");
    }

    public class Electric : Element
    {
        public new readonly ElementType Type = ElementType.Electric;
        public new readonly int TeamResonanceId = 10401;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ELEC_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ELEC_ENERGY;
        public new readonly int DepotValue = 7;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_Electric_Lv2");
    }
    public class Grass : Element
    {
        public new readonly ElementType Type = ElementType.Grass;
        public new readonly int TeamResonanceId = 10501;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_GRASS_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_GRASS_ENERGY;
        public new readonly int DepotValue = 8;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_Grass_Lv2");
    }

    public class Default : Element
    {
        public new readonly ElementType Type = ElementType.Default;
        public new readonly int TeamResonanceId = 10801;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
        public new readonly int ConfigHash = Utils.AbilityHash("TeamResonance_AllDifferent");
    }

    public class Frozen : Element
    {
        public new readonly ElementType Type = ElementType.Frozen;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ICE_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ICE_ENERGY;

    }

    public class AntiFire : Element
    {
        public new readonly ElementType Type = ElementType.AntiFire;
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
    }
}
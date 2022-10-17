using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems
{
    public class ElementType
    {
        [JsonProperty]
        public readonly Enums.ElementType Type;
        [JsonProperty]
        public readonly int TeamResonanceId;
        [JsonProperty]
        public readonly FightProperty CurEnergyProp;
        public float CurEnergy = 0;
        [JsonProperty]
        public readonly FightProperty MaxEnergyProp;
        public float MaxEnergy = 0;
        [JsonProperty]
        public readonly int DepotValue;
        [JsonProperty]
        public readonly int ConfigHash;
    }

    public class None : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.None;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
    }

    public class Fire : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Fire;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10101;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
        [JsonProperty]
        public new readonly int DepotValue = 2;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_Fire_Lv2");
    }

    public class Water : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Water;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10201;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_WATER_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_WATER_ENERGY;
        [JsonProperty]
        public new readonly int DepotValue = 3;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_Water_Lv2");
    }
    public class Wind : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Wind;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10301;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_WIND_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_WIND_ENERGY;
        [JsonProperty]
        public new readonly int DepotValue = 4;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_Wind_Lv2");
    }
    public class Ice : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Ice;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10601;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ICE_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ICE_ENERGY;
        [JsonProperty]
        public new readonly int DepotValue = 5;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_Ice_Lv2");
    }
    public class Rock : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Rock;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10701;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ROCK_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ROCK_ENERGY;
        [JsonProperty]
        public new readonly int DepotValue = 6;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_Rock_Lv2");
    }

    public class Electric : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Electric;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10401;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ELEC_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ELEC_ENERGY;
        [JsonProperty]
        public new readonly int DepotValue = 7;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_Electric_Lv2");
    }
    public class Grass : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Grass;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10501;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_GRASS_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_GRASS_ENERGY;
        [JsonProperty]
        public new readonly int DepotValue = 8;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_Grass_Lv2");
    }

    public class Default : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Default;
        [JsonProperty]
        public new readonly int TeamResonanceId = 10801;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
        [JsonProperty]
        public new readonly ulong ConfigHash = Utils.AbilityHash("TeamResonance_AllDifferent");
    }

    public class Frozen : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.Frozen;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_ICE_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_ICE_ENERGY;
    }

    public class AntiFire : ElementType
    {
        [JsonProperty]
        public new readonly Enums.ElementType Type = Enums.ElementType.AntiFire;
        [JsonProperty]
        public new readonly FightProperty CurEnergyProp = FightProperty.FIGHT_PROP_CUR_FIRE_ENERGY;
        [JsonProperty]
        public new readonly FightProperty MaxEnergyProp = FightProperty.FIGHT_PROP_MAX_FIRE_ENERGY;
    }
}
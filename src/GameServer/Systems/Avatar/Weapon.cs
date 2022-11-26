
namespace Weedwacker.GameServer.Systems
{

    public abstract class Weapon
    {
        public readonly int Value = 0;
        public readonly int EnergyGainInitialProbability = 0;
        public readonly int EnergyGainIncreaseProbability = 0;

        public Weapon() { }
        private Weapon(int value)
        {
            Value = value;
        }

        private Weapon(int value, int energyGainInitialProbability, int energyGainIncreaseProbability)
        {
            Value = value;
            EnergyGainInitialProbability = energyGainInitialProbability;
            EnergyGainIncreaseProbability = energyGainIncreaseProbability;
        }
    }
    public class WeaponNone : Weapon
    {

    }
    public class WeaponSwordOneHand : Weapon
    {
        public new readonly int Value = 1;
        public new readonly int EnergyGainInitialProbability = 10;
        public new readonly int EnergyGainIncreaseProbability = 5;
    }
    public class WeaponCrossbow : Weapon
    {
        public new readonly int Value = 2;
    }
    public class WeaponStaff : Weapon
    {
        public new readonly int Value = 3;
    }
    public class WeaponDoubleDagger : Weapon
    {
        public new readonly int Value = 4;
    }
    public class WeaponKatana : Weapon
    {
        public new readonly int Value = 5;
    }
    public class WeaponShuriken : Weapon
    {
        public new readonly int Value = 6;
    }
    public class WeaponStick : Weapon
    {
        public new readonly int Value = 7;
    }
    public class WeaponSpear : Weapon
    {
        public new readonly int Value = 8;
    }
    public class WeaponShieldSmall : Weapon
    {
        public new readonly int Value = 9;
    }
    public class WeaponCatalyst : Weapon
    {
        public new readonly int Value = 10;
        public new readonly int EnergyGainInitialProbability = 0;
        public new readonly int EnergyGainIncreaseProbability = 10;
    }
    public class WeaponClaymore : Weapon
    {
        public new readonly int Value = 11;
        public new readonly int EnergyGainInitialProbability = 0;
        public new readonly int EnergyGainIncreaseProbability = 10;
    }
    public class WeaponBow : Weapon
    {
        public new readonly int Value = 12;
        public new readonly int EnergyGainInitialProbability = 0;
        public new readonly int EnergyGainIncreaseProbability = 5;
    }

    public class WeaponPole : Weapon
    {
        public new readonly int Value = 13;
        public new readonly int EnergyGainInitialProbability = 0;
        public new readonly int EnergyGainIncreaseProbability = 4;
    }
}

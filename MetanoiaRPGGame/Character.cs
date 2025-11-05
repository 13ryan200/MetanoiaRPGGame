using System;

namespace MetanoiaRPGGame
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public int HP { get; set; }
        public int Attack { get; set; }
        public int SpecialAttack { get; set; }
        public int Mana { get; set; } = 0;
        public int MaxMana { get; set; } = 100;

        public bool CanUseSpecial => Mana >= MaxMana;

        public void GainMana(int amount)
        {
            Mana += amount;
            if (Mana > MaxMana) Mana = MaxMana;
        }

        public void UseMana()
        {
            Mana = 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"HP: {HP}\n" +
                   $"Attack: {Attack}\n" +
                   $"Special Attack: {SpecialAttack}";
        }
    }
}

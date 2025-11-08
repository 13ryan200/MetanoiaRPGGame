using System;

namespace MetanoiaRPGGame
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int XP { get; set; } = 0;
        public int XPToNextLevel { get; set; } = 100;
        private const int MaxLevel = 20;
        public int HP { get; set; } = 100;
        public int MaxHP { get; set; } = 10;
        public int Attack { get; set; } = 10;
        public int SpecialAttack { get; set; } = 30;
        public int Defense { get; set; }
        public int Stamina { get; set; }

        public int Mana { get; set; } = 20;
        public int MaxMana { get; set; } = 100;

        public bool CanUseSpecial => Mana >= 60;

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Level: {Level}\n" +
                   $"HP: {HP}/{MaxHP}\n" +
                   $"Attack: {Attack}\n" +
                   $"Special Attack: {SpecialAttack}\n" +
                   $"Mana: {Mana}/{MaxMana}\n" +
                   $"Defense: {Defense}";
        }

        public void GainMana(int amount)
        {
            if (Level >= MaxLevel)
                return;

            XP += amount;
            while (XP >= XPToNextLevel && Level < MaxLevel)
            {
                LevelUp();
            }
        }

        public void UseMana()
        {
            Mana = Math.Max(0, Mana + 50);
        }

        public void GainXP(int amount)
        {
            if (Level >= MaxLevel)
                return;

            XP += amount;
            while (XP >= XPToNextLevel && Level < MaxLevel)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            if (Level >= MaxLevel)
                return;

            XP -= XPToNextLevel;

            XPToNextLevel = (int)(XPToNextLevel * 1.2);

            Level++;

            HP += 100 + (Level * 2);
            Attack += 5;
            SpecialAttack += 10;
            Defense += 5;
            Mana = MaxMana;
        }

        public Character Clone()
        {
            return (Character)this.MemberwiseClone();
            
        }
    }
}

using System;

using System;

namespace MetanoiaRPGGame
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int XP { get; set; } = 0;
        public int XPToNextLevel { get; set; } = 100;

        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Attack { get; set; }
        public int SpecialAttack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public int Mana { get; set; } = 0;
        public int MaxMana { get; set; } = 100;

        public bool CanUseSpecial => Mana >= MaxMana;

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"HP: {HP}\n" +
                   $"Attack: {Attack}\n" +
                   $"Special Attack: {SpecialAttack}";
        }

        public void GainMana(int amount)
        {
            Mana += amount;
            if (Mana > MaxMana) Mana = MaxMana;
        }

        public void UseMana()
        {
            Mana = 0;
        }

        public void GainXP(int amount)
        {
            XP += amount;
            if (XP >= XPToNextLevel)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            XP -= XPToNextLevel;
            XPToNextLevel += 50;
            Level++;
            HP += 20;
            MaxMana += 10;
            Attack += 5;
            SpecialAttack += 5;
            Mana = 0;
            MaxHP += 20;
        }

        public Character Clone()
        {
            return new Character
            {
                Name = this.Name,
                HP = this.HP,
                Attack = this.Attack,
                SpecialAttack = this.SpecialAttack,
                Defense = this.Defense,
                Stamina = this.Stamina,
                Mana = this.Mana,
                Level = this.Level,
                XP = this.XP,
                MaxHP = this.MaxHP,
                MaxMana = this.MaxMana
            };
        }
    }
}

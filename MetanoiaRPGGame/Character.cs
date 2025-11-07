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

        public Character() { }

        public Character(string name, int hp, int attack, int special)
        {
            Name = name;
            HP = hp;
            MaxHP = hp;
            Attack = attack;
            SpecialAttack = special;
            MaxMana = 100;
            Mana = 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Level: {Level}\n" +
                   $"HP: {HP}/{MaxHP}\n" +
                   $"Attack: {Attack}\n" +
                   $"Special Attack: {SpecialAttack}\n" +
                   $"Mana: {Mana}/{MaxMana}\n" +
                   $"XP: {XP}/{XPToNextLevel}";
        }

        public void GainMana(int amount)
        {
            Mana += amount;
            if (Mana > MaxMana)
                Mana = MaxMana;
        }

        public void UseMana()
        {
            Mana = 0;
        }

        public void GainXP(int amount)
        {
            XP += amount;
            while (XP >= XPToNextLevel)
            {
                XP -= XPToNextLevel;
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level++;
            XPToNextLevel = (int)(XPToNextLevel * 1.5); 

            MaxHP += 100;
            Attack += 5;
            SpecialAttack += 5;
            MaxMana += 0;

            RefreshHP();
            Mana = 0;
        }

        public void RefreshHP()
        {
            HP = MaxHP;
            Mana = MaxMana;
        }

        public Character Clone()
        {
            return new Character
            {
                Name = this.Name,
                HP = this.HP,
                MaxHP = this.MaxHP,
                Attack = this.Attack,
                SpecialAttack = this.SpecialAttack,
                Defense = this.Defense,
                Stamina = this.Stamina,
                Mana = this.Mana,
                MaxMana = this.MaxMana,
                Level = this.Level,
                XP = this.XP,
                XPToNextLevel = this.XPToNextLevel
            };
        }
    }
}

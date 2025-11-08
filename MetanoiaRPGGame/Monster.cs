using System;

namespace MetanoiaRPGGame
{
    public class Monster
    {
        public string Name { get; set; } = string.Empty;
        public int HP { get; set; } = 150;
        public int Attack { get; set; } = 20;
        public int Defense { get; set; } = 10;

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"HP: {HP}\n" +
                   $"Attack: {Attack}\n"+
                   $"Defense: {Defense}";
        }
    }
}

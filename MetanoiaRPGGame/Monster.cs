using System;

namespace MetanoiaRPGGame
{
    public class Monster
    {
        public string Name { get; set; } = string.Empty;
        public int HP { get; set; }
        public int Attack { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"HP: {HP}\n" +
                   $"Attack: {Attack}";
        }
    }
}

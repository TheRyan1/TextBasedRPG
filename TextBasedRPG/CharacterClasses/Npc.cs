using System.Collections.Generic;
using TextBasedRPG.GameObjects;

namespace TextBasedRPG.CharacterClasses
{
    public class Npc : INpc
    {
        public CharacterStats Stats { get; set; }
        public List<string> Inventory { get; set; } = new() { "Box Of Gold", "Cheetos" };
    }
}
using System.Collections.Generic;
using TextBasedRPG.CharacterClasses;

namespace TextBasedRPG.GameObjects
{
    public interface IGameEntity
    {
        public CharacterStats Stats { get; set; }

        public List<string> Inventory { get; set; }
    }
}
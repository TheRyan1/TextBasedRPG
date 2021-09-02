using System;
using System.Collections.Generic;
using TextBasedRPG.GameObjects;
using TextBasedRPG.MainGameClasses;

namespace TextBasedRPG.LocationClasses
{
    public class DungeonGenerator
    {
        public readonly List<Action> Dungeons = new();
        public ScreenText _logger = new();

        public DungeonGenerator(IGameEntity player)
        {
       
        }

        public int RandomDungeon()
        {
            var rndm = new Random();
            return rndm.Next(0, 3);
        }
    }
}
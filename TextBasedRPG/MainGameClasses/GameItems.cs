using System.Collections.Generic;

namespace TextBasedRPG.MainGameClasses
{
   public class GameItems
    {
        public Dictionary<string, int> TraderInventory = new();
       

        public GameItems()
        {
            TraderInventory.Add("Rusty Sword", 5);
            TraderInventory.Add("Short Sword", 10);
            TraderInventory.Add("Long Sword", 15);
            TraderInventory.Add("Axe", 20);
            TraderInventory.Add("Bow", 40);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    public class Character
    {
       public CharacterInventory inventory = new();
       public CharacterStats stats = new();
       public ScreenText _logger = new();
        public string Name { get; set; }
     
   

        public Character()
        {
            Console.WriteLine("Enter a name for your Character");
            Name = Console.ReadLine();
            inventory.Gold = 0;


        }

        public void PrintPlayerInfo()
        {
            _logger.PrintToScreen($"Player {Name} : ");
            _logger.PrintToScreen($"Inventory: ");
            _logger.PrintToScreen($"Gold : {inventory.Gold} || Weapon : {inventory.Weapon} ");
            _logger.PrintToScreen($"Health : {stats.Health} || Damage per hit : {stats.Damage} ");

        }

    }
}

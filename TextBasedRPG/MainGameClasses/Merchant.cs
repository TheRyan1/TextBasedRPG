using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
   public class Merchant
   {
       public GameItems gameItems = new();
       public ScreenText _logger = new();
        public int gold;

       public Merchant()
       {
           gold = 50;

       }

       public void ListMerchantItems(Character player)
       {
          
           var count = 1;
           foreach (var i in gameItems.TraderInventory)
           {
               _logger.PrintToScreen($"( {count} ) : {i.Key} Gold: {i.Value}");
               count++;
           }


           var SelectedItem = gameItems.TraderInventory.ElementAt(Convert.ToInt32(Console.ReadLine()) - 1);

           if (SelectedItem.Value > player.inventory.Gold)
           {
               _logger.PrintToScreen("You don't have enough gold!!");
               
           }
           else
           {
               player.inventory.Gold -= SelectedItem.Value;
               player.inventory.Weapon = SelectedItem.Key;
               _logger.PrintToScreen($"You bought a {SelectedItem.Key}");
           }


       }
    }
}

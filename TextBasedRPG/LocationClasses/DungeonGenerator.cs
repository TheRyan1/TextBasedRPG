using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
  public class DungeonGenerator {

   public readonly List<Action> Dungeons = new();
   public ScreenText _logger = new();

   public DungeonGenerator()
   {
       Dungeons.Add(d1);
       Dungeons.Add(d2);
       Dungeons.Add(d3);
       Dungeons.Add(d4);
        }

   public int RandomDungeon()
   {
       var rndm = new Random();
       return rndm.Next(0, 3);
   }

   private void d1()
   {

       _logger.PrintToScreen("This is dungeon 1 \nSome text describing Dungeon 1");
       Console.ReadLine();
   }
   private void d2()
   {

       _logger.PrintToScreen("This is dungeon 2 \nSome text describing Dungeon 2");
       Console.ReadLine();
        }
   private void d3()
   {

       _logger.PrintToScreen("This is dungeon 3 \nSome text describing Dungeon 3");
       Console.ReadLine();
        }
   private void d4()
   {

       _logger.PrintToScreen("This is dungeon 4 \nSome text describing Dungeon 4");
       Console.ReadLine();
        }

    }
}

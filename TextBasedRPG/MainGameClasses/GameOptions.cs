using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
   public class GameOptions
   {
       
       public List<string> select = new();

       public GameOptions()
       {
           select.Add("( 1 ) : Player Info");
            select.Add("( 2 ) : Trader");
            select.Add("( 3 ) : Dungeon");
       }

       public void ops()
       {
           Console.WriteLine("choose an option");
           foreach (var i in select)
           {
               Console.WriteLine(i);
             
           }
       }
   }
}

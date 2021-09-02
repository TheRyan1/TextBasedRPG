using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
  public class BattleCalculator
    {


        public bool HaveHp(Enemies enemy, Character player)
        {
            return enemy.Health > 0 && player.stats.Health > 0;
        }
    }
}

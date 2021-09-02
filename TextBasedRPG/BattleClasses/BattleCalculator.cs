using TextBasedRPG.CharacterClasses;
using TextBasedRPG.EnemyClasses;

namespace TextBasedRPG.BattleClasses
{
  public class BattleCalculator
    {


        public bool HaveHp(Enemies enemy, Character player)
        {
            return enemy.Health > 0 && player.stats.Health > 0;
        }
    }
}

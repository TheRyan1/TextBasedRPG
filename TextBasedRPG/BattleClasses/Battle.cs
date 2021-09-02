using System;

namespace TextBasedRPG
{
    public class Battle
    {
        private static Random rndm = new Random();
        public BattleCalculator CheckFight = new ();
        private int currentHit;
        private ScreenText _logger = new ScreenText();
        private string UserChoice = "";
        public bool StartBattle(Enemies enemy, Character character)
        {
            _logger.PrintToScreen($"A {enemy.Name} with {enemy.Health}HP and {enemy.Damage} Damage points appears");
            _logger.PrintToScreen($"Player health {character.stats.Health}");

            while (CheckFight.HaveHp(enemy, character))
            {
                Console.WriteLine("( 1 ) : Continue fighting");
                Console.WriteLine("( 2 ) : Run away!");
                UserChoice = "";
                UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "1":
                        _logger.PrintToScreen($"{character.Name} attacking...");
                        //Create a 1,2 or 3 times damage multiplier
                        currentHit = character.stats.Damage * rndm.Next(1, 3);
                        _logger.PrintToScreen($"{character.Name} Hit's {enemy.Name} for {currentHit} points ...");
                        enemy.Health -= currentHit;
                        _logger.PrintToScreen($"{enemy.Name} attacking...");
                        currentHit = enemy.Damage * rndm.Next(1, 3);
                        _logger.PrintToScreen($"{enemy.Name} Hit's {character.Name} for {currentHit} points ...");
                        character.stats.Health -= currentHit;
                        _logger.PrintToScreen($"Enemy health {enemy.Health}");
                        _logger.PrintToScreen($"Player health {character.stats.Health}");
                        break;

                    case "2":
                        return true;
                }
            }
            if (enemy.Health < 1)
            {
                _logger.PrintToScreen($"Player Has defeated enemy. {enemy.Gold} gold has been looted and added to your inventory ");
                character.inventory.Gold += enemy.Gold;
                return true;
            }
            return false;
        }
    }
}

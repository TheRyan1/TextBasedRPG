using System;
using System.Diagnostics.Tracing;
using System.Net;
using System.Threading;

namespace TextBasedRPG
{
    class Program
    {


        static void Main(string[] args)
        {
            //Create new instances of the classes needed
            var player = new Character();
            var merchant = new Merchant();
            var dungeonGenerator = new DungeonGenerator();
            var battleTime = new Battle();
            var dialogue = new GameOptions();

            //Set the game state to true
            var activeGame = true;
        
            // variable for player choice
            var playerInput = "";

            while (activeGame) 
            {
                dialogue.ops();
                playerInput = Console.ReadLine()?.ToLower();
                if (player.stats.Health > 0)
                {
                    switch (playerInput)
                    {
                        case "1":
                            player.PrintPlayerInfo();
                            break;

                        case "2":
                            merchant.ListMerchantItems(player);
                            break;

                        case "3":
                            // Generate a random dungeon
                            dungeonGenerator.Dungeons[dungeonGenerator.RandomDungeon()]();
                            // pass the new enemy instance and the player into the battleObject
                            activeGame = battleTime.StartBattle(new Enemies(), player);
                            break;
                    }

                }
                else if (player.stats.Health < 1)
                {
                    activeGame = false;
                    
                }
            } 

            Console.WriteLine("you died");
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net;
using System.Threading;
using TextBasedRPG.BattleClasses;
using TextBasedRPG.CharacterClasses;
using TextBasedRPG.EnemyClasses;
using TextBasedRPG.GameObjects;
using TextBasedRPG.LocationClasses;
using TextBasedRPG.MainGameClasses;

namespace TextBasedRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new instances of the classes needed
            var player = new Character();
            var merchant = new Merchant();
            var npc = new Npc();
            var dungeonGenerator = new DungeonGenerator();
            var battleTime = new Battle();
            var dialogue = new GameOptions();

            var enemyFactory = new EnemyFactory(player);
            var enemies = enemyFactory.Generate(10);

            var tradeRoom  = new TradeRoom<Character, Npc>(player, npc);
            tradeRoom.MakeTrade(0);
            tradeRoom.MakeTrade(1);
            
            // v      
            player.MakeTrade(npc, 0);
            
            player.MakeTrade(npc, 0);
            
            
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
                            activeGame = battleTime.StartBattle(player);
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
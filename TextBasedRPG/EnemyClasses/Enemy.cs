using System;
using System.Collections.Generic;
using TextBasedRPG.CharacterClasses;
using TextBasedRPG.GameObjects;

namespace TextBasedRPG.EnemyClasses
{
    public enum Difficulty
    {
        Easy,
        Challenging,
        Hard
    }
    
    public class Enemy: IGameEntity, IEnemy
    {
        public Enemy(IPlayer player)
        {
            switch (player.Level)
            {
                case int n when (n >= 0 && n <= 25):
                    Type = EnemyTypes.Imp;
                    break;
                case int n when (n > 25 && n <= 70):
                    Type = EnemyTypes.Juggernaut;
                    break;
                case int n when (n > 70 && n <= 100):
                    Type = EnemyTypes.Asshole;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Fuuuuu");
            }
        }
        
        public CharacterStats Stats { get; set; }

        public List<string> Inventory { get; set; } = new() { "Shoe", "Cockring" };
        public EnemyTypes Type { get; set; }
    }

    public class EnemyFactory
    {
        private readonly IPlayer _player;

        public EnemyFactory(IPlayer player)
        {
            _player = player;
        }

        public List<Enemy> Generate(int enemyCount)
        {
            var enemies = new List<Enemy>();
            for (var i = 0; i < enemyCount; i++)
            {
                enemies.Add(new Enemy(_player));
            }

            return enemies;
        }
    }
}
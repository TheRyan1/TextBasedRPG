using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    public class Enemies
    {

        public int Health;
        public int Damage;
        public string Name = "Goblin";
        public int Gold = 0;
        Random rndm = new Random();
      
        public Enemies()
        {
            Health = rndm.Next(50, 150);
            Damage = rndm.Next(10, 20);
            Gold = rndm.Next(1, 20);
        }

       




    }
}

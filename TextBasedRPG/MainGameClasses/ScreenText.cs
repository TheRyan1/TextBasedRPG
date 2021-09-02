using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextBasedRPG
{
    public class ScreenText
    {
       

        public void PrintToScreen(string sentence )
        {
            Char[] sentenceArray = sentence.ToCharArray();
          
            foreach (var i in sentence)
            {
               
                Console.Write(i);
                Thread.Sleep(30);
            }
            Console.WriteLine();


        }
    }
}

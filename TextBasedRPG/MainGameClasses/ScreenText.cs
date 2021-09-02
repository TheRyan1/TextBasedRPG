using System;
using System.Threading;

namespace TextBasedRPG.MainGameClasses
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

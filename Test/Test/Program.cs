using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Random rand = new Random ();
           
            int diceroll = 0;

            while (diceroll < 10)
            {
                
                int randomnum = rand.Next(1, 7);

                Console.WriteLine (randomnum);

                diceroll++;
            }


        }
    }
}

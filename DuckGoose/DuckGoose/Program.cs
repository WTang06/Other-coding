using System;

namespace DuckGoose
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 24;
            string msg;

            while (n > 0)
            {
                if (n > 10)
                {
                    msg = "Duck!";
                }
                else
                {
                    msg = "Goose!";
                }

                Console.WriteLine(msg);

                n--;

            }
        }
    }
}

using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coinflip = new Random();
            int[] holder = { };
            int adder = 0, subber;
            for (int y = 0; y <= 9; y++) { 
            for (int x = 0; x < 1000; x++)
            {
                int hort = coinflip.Next(1, 3);
                if (hort == 1)
                {
                    adder = adder + 1;
                }
            }
            subber = 1000 - adder;
            Console.WriteLine($"Head was found {adder} times. Tails was found {subber} times.");
                subber = 0;
                adder = 0;
            }
        }
    }
}

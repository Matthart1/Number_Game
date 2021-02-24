using System;

namespace pickANumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool win = false;

            do
            {
                Console.WriteLine("Guess a numeber.");
                var guess = int.Parse(Console.ReadLine());
                int answer = (69);

                if (guess < answer)
                {
                    Console.WriteLine("Try going up some.");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Bring it down a bit.");
                }

                //*the following do not add 10 to the guess before processing*
                //else if (guess+10 > answer)
                //{
                //    Console.WriteLine("You're way off!");
                //}
                else
                {
                    Console.WriteLine("Bingo!!");
                    win = true;
                }


            } while (win == false);
        }
    }
}

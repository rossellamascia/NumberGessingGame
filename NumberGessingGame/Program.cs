using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGussingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int winNum = random.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);
                if (i > winNum)
                {
                    Console.WriteLine("To high! Guess lower...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("To low! Guess higher...");
                }
                else if (i == winNum) {
                    Console.WriteLine("You WIN!");
                    win = true;
                }
            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true);

        }
    }
}
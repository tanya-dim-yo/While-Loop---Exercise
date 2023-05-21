using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakesPieces = width * length;

            while (cakesPieces > 0)
            {
                string currentTake = Console.ReadLine();

                if (currentTake == "STOP")
                {
                    break;
                }

                cakesPieces -= int.Parse(currentTake);
            }

            if (cakesPieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(0 - cakesPieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(cakesPieces - 0)} pieces are left.");

            }
        }
    }
}
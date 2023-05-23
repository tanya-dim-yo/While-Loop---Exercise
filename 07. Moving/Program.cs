using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = width * length * height;

            while (area > 0)
            {
                string currentBox = Console.ReadLine();

                if (currentBox == "Done")
                {
                    break;
                }

                area -= int.Parse(currentBox);
            }

            if (area <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(0 - area)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{area - 0} Cubic meters left.");
            }
        }
    }
}
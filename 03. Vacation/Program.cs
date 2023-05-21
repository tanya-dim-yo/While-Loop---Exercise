using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumNeeded = double.Parse(Console.ReadLine());
            double sumAvailable = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (sumAvailable < sumNeeded && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (action == "save")
                {
                    sumAvailable += money;
                    spendingCounter = 0;
                }
                else if (action == "spend")
                {
                    sumAvailable -= money;
                    spendingCounter++;

                    if (sumAvailable < 0)
                    {
                        sumAvailable = 0;
                    }
                }
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (sumAvailable >= sumNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");

            }
        }
    }
}
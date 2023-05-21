using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsNeeded = 10000;
            int stepsToGoal = 0;

            while (stepsToGoal < stepsNeeded)
            {
                string currentSteps = Console.ReadLine();

                if (currentSteps == "Going home")
                {
                    int finalSteps = int.Parse(Console.ReadLine());
                    stepsToGoal += finalSteps;
                    break;
                }

                stepsToGoal += int.Parse(currentSteps);
            }

            if (stepsToGoal >= stepsNeeded)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsToGoal - stepsNeeded} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsNeeded - stepsToGoal} more steps to reach goal.");
            }
        }
    }
}
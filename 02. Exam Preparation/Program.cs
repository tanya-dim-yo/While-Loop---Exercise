using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGradesCount = int.Parse(Console.ReadLine());
            int poorGradesCounter = 0;
            int solvedAssignmentsCounter = 0;
            double gradesSum = 0;
            bool isFailed = true;
            string lastProblem = "";

            while (poorGradesCounter < poorGradesCount)
            {
                string nextAssignment = Console.ReadLine();

                if (nextAssignment == "Enough")
                {
                    isFailed = false;
                    break;
                }

                int nextAssignmentGrade = int.Parse(Console.ReadLine());

                if (nextAssignmentGrade <= 4)
                {
                    poorGradesCounter++;
                }

                solvedAssignmentsCounter++;
                gradesSum += nextAssignmentGrade;
                lastProblem = nextAssignment;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedAssignmentsCounter:F2}");
                Console.WriteLine($"Number of problems: {solvedAssignmentsCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTests = 0;
            Console.WriteLine("Welcome to the Circle Tester!");
            bool continueProgram;
            do
            {
                Console.Write("Enter radius: ");

                var circle1 = new Circle(Validator.Validate(Console.ReadLine()));

                Console.WriteLine($"Circumference: {circle1.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area:          {circle1.CalculateFormattedArea()}");
                numOfTests++;
                var continue1 = new Continue();
                continueProgram = continue1.DetermineStatus();
            } while (continueProgram);

            Console.WriteLine("____________________________________________");
            Console.WriteLine($"Goodbye. You created {numOfTests} Circle object(s).");
            Console.ReadKey();
        }
    }
}

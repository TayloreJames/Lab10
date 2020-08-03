using System;
namespace Lab10
{
    public class Continue
    {
        private string UserInput { get; set; }

        public bool DetermineStatus()
        {
            Console.Write("Continue? (y/n): ");
            UserInput = Console.ReadLine();

            while (true)
            {
                if (UserInput == "y")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (UserInput == "n") return false;
                else
                {
                    Console.Write("Invalid entry. Please select y to continue the program or n to cancel: ");
                    UserInput = Console.ReadLine();
                }
            } 
        }
    }
}
   
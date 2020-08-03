using System;
namespace Lab10
{
    public class Validator
    {
        public static double Validate(string userInput)
        {
            double inputNum;
            while (true)
            {
                //switch to ternary?
                if (double.TryParse(userInput, out inputNum))
                {
                    if (inputNum >= 0) return inputNum;
                }               
 
                Console.Write("Invalid entry. Please enter a number greater than 0: ");
                userInput = Console.ReadLine();
             
            }
        }
    }
}

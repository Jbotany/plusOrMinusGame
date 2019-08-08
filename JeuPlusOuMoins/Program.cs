using System;

namespace JeuPlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int maxValue = 101;

            int numberToBeFound = rand.Next(maxValue);

            bool over = false;

            int numberOfTries = 0;

            Console.WriteLine("Welcome to the Plus or minus game!");
            Console.WriteLine("Please enter a number and try to find the secret number (between 0 and 100)");

            while (!over)
            {
                string input = Console.ReadLine();

                int inputToNumber;

                if (int.TryParse(input, out inputToNumber))
                {
                    numberOfTries++;

                    if (inputToNumber < 0 || inputToNumber > 100)
                    {
                        Console.WriteLine("Please enter an integer between 0 and 100");
                    }
                    else if (inputToNumber == numberToBeFound)
                    {
                        Console.WriteLine("Success !");
                        Console.WriteLine("Number to be found : " + numberToBeFound);
                        Console.WriteLine("Your number : " + inputToNumber);
                        Console.WriteLine("Tries needed : {0}", numberOfTries);
                        over = true;
                    }
                    else if (inputToNumber < numberToBeFound)
                    {
                        Console.WriteLine("Try a higher number");
                    }
                    else
                    {
                        Console.WriteLine("Try a lower number");
                    }
                }
                else
                {
                    numberOfTries++;

                    Console.WriteLine("Please, only enter an integer");
                }
            }

            Console.Read();
        }
    }
}

using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Subject = "CSharp";
            Console.WriteLine("Please choose a subject: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "CSharp":
                    Console.WriteLine("You are in one of the best classes!");
                    break;

                case "Chemisty":
                    Console.WriteLine("Wow that's a first!");
                    break;

                case "Computer Science":
                    Console.WriteLine("You rock!");
                    break;

                case "Physics":
                    Console.WriteLine("You are doing great!");
                    break;

                case "English":
                    Console.WriteLine("Way to go Shakespheare!");
                    break;
                default:
                    Console.WriteLine("Sorry, but this is not a valid input!");
                    break;
            }

        }
    }
}

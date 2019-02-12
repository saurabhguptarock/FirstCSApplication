using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string AppName = "Guess Number";
            string AppVersion = " 1.0.0";
            string Author = "Saurabh";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version{1} by {2}", AppName, AppVersion, Author);
            Console.ResetColor();

            Console.WriteLine("What is your name");
            string inputname = Console.ReadLine();
            Console.WriteLine("Hello {0}, Let's Play a Game....", inputname);

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string no = Console.ReadLine();
                    if (!int.TryParse(no, out guess))
                    {
                        printColorMessage(ConsoleColor.Red, "Please enter an integer!!!");
                        continue;
                    }
                    guess = Int32.Parse(no);

                    if (guess != correctNumber)
                        printColorMessage(ConsoleColor.Red, "Wrong no Please try again");
                }
                printColorMessage(ConsoleColor.Yellow, "You are Correct");

                printColorMessage(ConsoleColor.Green, "Want to play again [Y / N]");


                string ch = Console.ReadLine().ToUpper();
                if (ch == "Y")
                    continue;
                else
                    break;
            }
        }
        static void printColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

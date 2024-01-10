using System;

namespace ClinicalMaestro
{
    class Program
    {
        static int PrintMenu()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Problems menu:");
                    Console.WriteLine("1- Highest Possible Number");
                    Console.WriteLine("2- Alphabet Position");
                    Console.WriteLine("3- Exit");
                    Console.WriteLine("Please, enter problem number:");

                    string input = Console.ReadLine();
                    int choice = int.Parse(input);
                    if (choice >= 1 && choice <= 3) return choice;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a valid integer.");
                }
            }

        }
        static void Main(string[] args)
        {
            int choice = PrintMenu();
            while (choice >= 1 && choice < 3)
            {
                bool exit = false;
                switch (choice)
                {
                    case 1:
                        Problem1 problem1 = new Problem1();
                        problem1.Start();
                        return ;
                        // break;

                    case 2:
                    
                        break;

                    default:
                        exit = true;
                        break;
                }
                if (exit) break;

            }

        }
    }
}

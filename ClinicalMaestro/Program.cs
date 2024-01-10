using System;

namespace ClinicalMaestro
{
    public class Program
    {
        public static int PrintMenu(Func<string> inputProvider)
        {

            // try
            // {
                Console.WriteLine("Problems menu:");
                Console.WriteLine("1- Highest Possible Number");
                Console.WriteLine("2- Alphabet Position");
                Console.WriteLine("3- Exit");
                Console.WriteLine("Please, enter problem number:");

                string input = inputProvider();
                int choice = int.Parse(input);
                if (choice >= 1 && choice <= 3) return choice;
            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("The input is not a valid integer.");
            // }

            return -1;
        }

        static void Main(string[] args)
        {
            int choice = PrintMenu(Console.ReadLine);
            while (choice >= 1 && choice < 3)
            {
                bool exit = false;
                switch (choice)
                {
                    case 1:
                        Problem1 problem1 = new Problem1();
                        problem1.Start();
                        return;
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

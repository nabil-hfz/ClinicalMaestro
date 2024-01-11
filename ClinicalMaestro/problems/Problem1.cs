namespace ClinicalMaestro
{
    public class Problem1
    {
        public Problem1()
        {
        }

        // This method starts the process.
        public void Start()
        {
            // Get a non-negative integer from the user.
            long num = GetInt();

            // Calculate the highest possible number by rearranging its digits.
            long result = GetHighestPossibleNumber(num);

            Console.WriteLine("Highest Possible Number is " + result);
        }

        // Method to rearrange the digits of a number to form the highest possible number.
        public long GetHighestPossibleNumber(long num)
        {
            long result = 0;

            // Array to keep track of the count of each digit (0-9).
            int[] numbers = new int[10];

            // Break down the number into digits and count the occurrence of each digit.
            while (num != 0)
            {
                var rest = (int)(num % 10);
                numbers[rest]++;
                num /= 10;
            }

            // Multiplier used for placing digits at the correct position in the result.
            long multiplier = 1;

            // Construct the largest number by adding the highest digits first.
            for (int i = 0; i < 10; i++)
            {
                // Add each digit the number of times it appears.
                while (numbers[i] > 0)
                {
                    result += multiplier * i;
                    multiplier *= 10;
                    numbers[i]--;
                }
            }
            return result;
        }

        // Method to get a non-negative integer input from the user.
        public long GetInt()
        {
            while (true)
            {
                try
                {
                    // Prompt the user to enter a number.
                    Console.WriteLine("Please, enter non-negative number:");

                    // Read and parse the user input.
                    string input = Console.ReadLine();
                    long choice = long.Parse(input);

                    // Check if the number is non-negative.
                    if (choice >= 0)
                        return choice;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a valid integer.");
                }
            }
        }
    }
}

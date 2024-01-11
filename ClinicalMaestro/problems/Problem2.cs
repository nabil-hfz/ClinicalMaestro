using System;
using System;
using System.Text;

namespace ClinicalMaestro
{

    public class Problem2
    {
        public void Start()
        {
            Console.WriteLine("Enter String: ");
            string input = Console.ReadLine();
            string result = ConvertToAlphabetPosition(input);
            Console.WriteLine("Alphabet Position is " + result);
        }

        public string ConvertToAlphabetPosition(string text)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    // Convert character to uppercase, then to its alphabet position
                    int position = char.ToUpper(c) - 'A' + 1;
                    result.Append(position.ToString() + " ");
                }
            }

            // Remove the trailing space and return the result
            return result.ToString().Trim();
        }

    }
}

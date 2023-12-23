using System;
using System.Text.RegularExpressions;

namespace RegularExpressions2
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\D+";

            var regex = new Regex(pattern);
            var array = new[] { "test", "123", "test123test", "123test", "test123" };

            foreach (string element in array)
            {
                Console.WriteLine(
                    regex.IsMatch(element)
                        ? $"String \"{element}\" matched \"{pattern}\""
                        : $"String \"{element}\" NOT matched \"{pattern}\"");
                Console.WriteLine(new string('-', 50));
            }

            pattern = "^[A-Z][a-z]*$";
            regex = new Regex(@"^(\+?38)?0(\(\d{2}\)|\d{2})\d{3}-?\d{2}-?\d{2}$");

            Console.WriteLine("\n\n");
            while (true)
            {
                Console.WriteLine("Enter string: ");
                string input = Console.ReadLine();

                if (input == "exit")
                    break;

                Console.WriteLine(
                    input != null && regex.IsMatch(input)
                        ? $"String \"{input}\" matched pattern"
                        : $"String \"{input}\" NOT matched pattern");

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
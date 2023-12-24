using System;
using System.Text.RegularExpressions;

/*
    КВАНТИФИКАТОРЫ
    ^ - c начала строки. 
    $ - с конца строки. 
    * - ноль и более вхождений подшаблона в строке.  
    + - одно и более вхождений подшаблона в строке.  
    ? - ноль или одно вхождений подшаблона в строке.  
 */

namespace RegularExpressions3
{
    class Program
    {
        static void Main()
        {
            string pattern;


            // Одно вхождение подстроки(\d+) в строку.
            //pattern = @"\d+";     // "123", "test123", "123test", "te123st", "4556yyy789"

            // Нужная подстрока(\d+) должна быть в начале строки.
            //pattern = @"^\d+";  // "123", "123test", "4556yyy789"

            // Нужная подстрока(\d+) должна быть в конце строки.
            //pattern = @"\d+$";  // "123", "test123", "4556yyy789"

            // Вся строка полностью от начала(^) и до конца($) должна соответствовать тому, что между ^ и $ (\d в данном стучае).
            pattern = @"^\d+$"; // "123"


            var regex = new Regex(pattern);
            var array = new[] { "test", "123", "test123", "123test", "te123st", "4556yyy789" };

            foreach (String element in array)
            {
                Console.WriteLine(
                    regex.IsMatch(element)
                        ? $"String \"{element}\" matched \"{pattern}\""
                        : $"String \"{element}\" NOT matched \"{pattern}\"");
                Console.WriteLine(new string('-', 50));
            }
            Console.ReadKey();

            string value = "4 - 5 AND 5 y 789";
         
            // Get first match.
            Match match = Regex.Match(value, @"\d");

            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }

            // Get second match.
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }

            // Get all matches.
            while (match.Success)
            {
                match = match.NextMatch();
                Console.WriteLine(match.Value);
            }
            Console.ReadKey();

            ///////////////////////////////////////////////
            //
            Match m = Regex.Match("123 Axx-1-xxy \n Axyx-2-xyyxy", @"A.*y");
            // * - is one of the most permissive because
            //it matches zero or more occurrences of any character
            if (m.Success)
            {
                Console.WriteLine("Value  = " + m.Value);
                Console.WriteLine("Length = " + m.Length);
                Console.WriteLine("Index  = " + m.Index);
            }
            m = m.NextMatch();
            if (m.Success)
            {
                Console.WriteLine("Value  = " + m.Value);
                Console.WriteLine("Length = " + m.Length);
                Console.WriteLine("Index  = " + m.Index);
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();

            ////////////////////////////////////Matches

            const string value1 = @"saidsaid baid shed shed see spear spread super";

            // Get a collection of matches.
            MatchCollection matches = Regex.Matches(value1, @"s\w+d");
            Console.WriteLine("-----");
            foreach (Match match1 in matches)
            {
                foreach (Capture capture in match1.Captures)
                {
                    Console.WriteLine($"Index={capture.Index}, Value={capture.Value}");
                }
            }
            Console.WriteLine("-----");
            foreach (Match match1 in matches)
            {
                Console.WriteLine($"Index={match1.Index}, Value={match1.Value}");
            }
            Console.WriteLine("-----");

            //////////////Replace
            string input = "Dont replace Dot Net replaced Not Nat dots";
            string output = Regex.Replace(input, "N.t", "NET");

            Console.WriteLine(input);
            Console.WriteLine(output);

            /////////////////////

            // //
            // // Now we have each number string.
            // //
            // foreach (string value3 in digits)
            // {
            //     int number;
            //     if (int.TryParse(value3, out number))
            //     {
            //         Console.WriteLine($"{value} - {number} hello");
            //     }
            // }

            ///////////////////////////
            Console.ReadKey();
        }
    }
}
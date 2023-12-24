using System;
using System.Globalization;
using System.Text.RegularExpressions;

//  System.Text.RegularExpressions 
/*
    СПЕЦ. СИМВОЛИ
    \d - Определяет символы цифр. 
    \D - Определяет любой символ, который не является цифрой. 
    \w - Определяет любой символ цифры, буквы или подчеркивания. 
    \W - Определяет любой символ, который не является цифрой, буквой или подчеркиванием. 
    \s - Определяет любой непечатный символ, включая пробел. 
    \S - Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
    .  - Определяет любой символ кроме символа новой строки.  
    \. - Определяет символ точки.
        
*/

namespace RegularExpressions
{
    class Program
    {
        static void Main()
        {
            // numbers
            var regex = new Regex(@"\d"); // ^\d{3}$
            bool flag = true;

            while (flag)
            {

                string @string = Console.ReadLine();

                if (@string == " ")
                {
                    flag = false;
                }
                bool success = regex.IsMatch(@string);

                Console.WriteLine(success ? " match found \"{0}\"" : $" match NOT found \"\\d\"");
            }
        }
    }
}
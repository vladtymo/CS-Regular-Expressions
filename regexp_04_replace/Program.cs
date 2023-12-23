using System;
using System.Text.RegularExpressions;

namespace regexp_04_replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "blalba 847563981 argg aeg aegha 454545451 ajerg ia 987654321 Bye!";
            string output = Regex.Replace(text, @"(\d{2})(\d{2})(\d{2})(\d{3})", "+38 (0$1)-$2-$3-$4");
            //string output = Regex.Replace(text, @"\d{9}", (m) => string.Format("{0:+38 (0##)-##-##-###}", Convert.ToInt64(m.Value)));
            Console.WriteLine(output);
        }
    }
}

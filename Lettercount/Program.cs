using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lettercount
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string sentence = Console.ReadLine();
                var results = StringLetterCount(sentence);
                Console.WriteLine($"CountLetters: {results}");
            }
        }
        static string StringLetterCount(string str)
        {
            string value = string.Empty;

            if (str.All(x => char.IsLetter(x) || x == ' ' || x == '.' || x == ','))
            {
                var order = str.ToLower().OrderBy(x => x);
                var countLetter = order.GroupBy(x => x)
                    .Where(x => x.Key != ' ')
                    .Where(x => x.Key != '.')
                    .Where(x => x.Key != ',')
                    .Select(x => $"{x.Count()}{x.Key}");
                value = string.Join("", countLetter);
            }
            else
                value = "";
            return value;
        }
    }
}

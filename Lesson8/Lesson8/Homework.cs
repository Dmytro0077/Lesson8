using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson8
{
    class Homework
    {
        static void Main(string[] args)
        {
            string[] phoneBook = { "Brad Pitt - 55562578699",
                                   "Denzel Washington - 5554238946",
                                   "Sean Connery - 5558723458" };

            int counter;
            string? answer;

            List<string> result = new List<string>();
            do
            {
                Console.WriteLine("Введеіть літери або цифри для пошуку контакту:");
                answer = Console.ReadLine();
            }
            while (answer == string.Empty);

            Regex regex = new Regex(answer, RegexOptions.IgnoreCase);

            foreach (var contacts in phoneBook)
            {
                MatchCollection matches = regex.Matches(contacts);
                counter = matches.Count;
                if (matches.Count > 0)
                {
                    result.Add(contacts);
                }
            }
            
            if (result.Count > 0)
            {
                Console.WriteLine("Знайдено співпадіння:");
                foreach (var person in result)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Контактів за вашим запитом не знайдено!");
            }
        }
    }
}
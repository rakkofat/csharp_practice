using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a numbers separated by commas: ");
            string input = Console.ReadLine();
            try
            {
                Console.WriteLine(AddStrings(input));
            }
            catch
            {
                Console.WriteLine("Ooh, you failed to follow instructions. Boo.");
            }
            
            Console.ReadKey();
        }

        public static int AddStrings(string numbers)
        {
            var total = 0;
            string[] separators = { ",", " " };
            string[] result = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string n in result)
            {
                total += int.Parse(n);
            }
            return total;
        }
    }
}

using System;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            PrintStringTimes(text, count);
        }

        static void PrintStringTimes(string text, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(text);
            }

            Console.WriteLine(result.ToString());
        }
    }
}

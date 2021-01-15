using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string firstString = string.Empty;
            string secondString = string.Empty;

            switch (input)
            {
                case "string":
                    GetMaxString(firstString, secondString);
                    break;
                case "int":
                    GetMaxInt(input);
                    break;
                case "char":
                    GetMaxChar(input);
                    break;
            }
        }

        private static void GetMaxString(string firstString, string secondString)
        {
            firstString = Console.ReadLine();
            secondString = Console.ReadLine();
            int result = String.Compare(firstString, secondString);

            if (result > 0)

            {
                Console.WriteLine(firstString);
            }

            else if (result < 0)
            {
                Console.WriteLine(secondString);
            }

        }
        private static void GetMaxInt(string input)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }

        private static void GetMaxChar(string input)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar > secondChar)
            {
                Console.WriteLine(firstChar);
            }
            else
            {
                Console.WriteLine(secondChar);
            }
        }
    }
}

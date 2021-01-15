using System;

namespace Math_operations
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            double result = 0;
            result = MathOperations(a, @operator, b);
            Console.WriteLine(result);
        }

        private static double MathOperations(int a, string @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }
            return result;
        }
    }
}

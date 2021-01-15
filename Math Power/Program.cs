using System;

namespace Math_Power
{
    class Program
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = CaculateMathPower(number, power);

            Console.WriteLine(result);
        }

        private static double CaculateMathPower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}


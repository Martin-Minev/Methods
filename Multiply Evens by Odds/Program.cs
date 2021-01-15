using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            GetMultipleOfEvenAndOdds(inputNumber);
        }

        private static int GetSumOfOddDigits(int inputNumber)
        {
            int sumOdds = 0;
            int numberToAbs = Math.Abs(inputNumber);
            int digit = 0;

            while (numberToAbs != 0)
            {
                digit = numberToAbs % 10;

                if (digit % 2 != 0)
                {
                    sumOdds += digit;
                }

                numberToAbs = numberToAbs / 10;
            }
            return sumOdds;
        }

        private static int GetSumOfEvenDigits(int inputNumber)
        {
            int sumEvens = 0;
            int numberToAbs = Math.Abs(inputNumber);
            int digit = 0;

            while (numberToAbs != 0)
            {
                digit = numberToAbs % 10;

                if (digit % 2 == 0)
                {
                    sumEvens += digit;
                }

                numberToAbs = numberToAbs / 10;
            }
            return sumEvens;
        }

        private static void GetMultipleOfEvenAndOdds(int inputNumber)
        {
            GetSumOfEvenDigits(inputNumber);

            int sumOdds = GetSumOfOddDigits(inputNumber);
            int sumEvens = GetSumOfEvenDigits(inputNumber);

            int multipleOfEvensAndOdds = sumEvens * sumOdds;
            Console.WriteLine(multipleOfEvensAndOdds);
        }
    }
}

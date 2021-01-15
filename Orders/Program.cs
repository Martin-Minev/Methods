using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    CalculateCoffeePrice(quantity);
                    break;
                case "water":
                    CalculateWaterPrice(quantity);
                    break;
                case "coke":
                    CalculateCokePrice(quantity);
                    break;
                case "snacks":
                    CalculateSnacksPrice(quantity);
                    break;
            }
        }

        private static void CalculateSnacksPrice(int quantity)
        {
            Console.WriteLine($"{(2.00 * quantity):F2}");
        }

        private static void CalculateCokePrice(int quantity)
        {
            Console.WriteLine($"{(1.40 * quantity):F2}");
        }

        private static void CalculateWaterPrice(int quantity)
        {
            Console.WriteLine($"{(1.00 * quantity):F2}");
        }
        private static void CalculateCoffeePrice(int quantity)
        {
            Console.WriteLine($"{(1.50 * quantity):F2}");
        }
    }
}

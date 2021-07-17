using System;

namespace GreateCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number2");
            var number2 = int.Parse(Console.ReadLine());

            var result = IntegerExtensions.FindGcd(number1, number2);
            Console.WriteLine(result);
        }
    }
}

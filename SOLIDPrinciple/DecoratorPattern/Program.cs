using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea cupOfTea1 = new GreenTea();
            cupOfTea1 = new SugarAdditive(cupOfTea1);
            Console.WriteLine($"Name: {cupOfTea1.Name}");
            Console.WriteLine($"Price: {cupOfTea1.Price}");

            Tea cupOfTea2 = new BlackTea();
            cupOfTea2 = new SugarAdditive(cupOfTea2);
            cupOfTea2 = new MilkAdditive(cupOfTea2);
            Console.WriteLine($"Name: {cupOfTea2.Name}");
            Console.WriteLine($"Price: {cupOfTea2.Price}");

            Tea cupOfTea3 = new RedTea();
            cupOfTea3 = new MilkAdditive(cupOfTea3);
            Console.WriteLine($"Name: {cupOfTea3.Name}");
            Console.WriteLine($"Price: {cupOfTea3.Price}");
        }
    }
}

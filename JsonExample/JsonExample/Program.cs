using System;
using System.Text.Json;

namespace JsonExample
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            Person jarry = new Person{Name = "Jarry", Age = 23};
            Person tom = new Person { Name = "Tom", Age = 31 };
            string json = JsonSerializer.Serialize<Person>(jarry);
            string tomJson = JsonSerializer.Serialize<Person>(tom);
            Console.WriteLine(json);
            Console.WriteLine(tom);
            Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restoredPerson.Name);
        }
    }
}

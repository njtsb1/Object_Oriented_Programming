using System;

namespace ExemploPOO.Models
{
    public class Person
    {
        public string Name { get; set; }

        public int Age {get; set; }

        public string Document { get; set; }

        public virtual void Tointroduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old");
        }
    }
}
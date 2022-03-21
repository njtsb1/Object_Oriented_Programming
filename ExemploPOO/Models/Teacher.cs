using System;

namespace ExemploPOO.Models
{
    public class Teacher : Person
    {
        public double Wage { get; set; }

        public override void Tointroduce()
        {
            Console.WriteLine($"Hello my name is {Name} and I am a teacher, and I earn {Wage}");
        }
    }
}
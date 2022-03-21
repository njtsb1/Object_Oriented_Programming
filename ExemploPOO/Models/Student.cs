using System;

namespace ExemploPOO.Models
{
    public class Student : Person
    {
        public int Note { get; set; }

        public override void Tointroduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am a student grade {Note}");
        }
    }
}
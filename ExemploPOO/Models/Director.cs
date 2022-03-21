using System;

namespace ExemploPOO.Models
{
    public class Director : Teacher
    {
        public override void Tointroduce()
        {
            Console.WriteLine($"Director");
        }        
    }
}
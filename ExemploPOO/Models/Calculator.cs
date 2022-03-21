using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
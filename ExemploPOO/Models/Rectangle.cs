namespace ExemploPOO.Models
{
    public class Rectangle
    {
        private double length;
        private double width;
        private bool valid;

        public void DefineMeasures(double length, double width)
        {            
            if (length > 0 && width > 0)
            {
                this.length = length;
                this.width = width;
                valid = true;
            }
            else
            {
                System.Console.WriteLine("Invalid values");
            }
        }

        public double GetArea()
        {
            if (valid)
            {
                return length * width;
            }
            else
            {
                System.Console.WriteLine("Fill in valid values");
                return 0;
            }
        }
    }
}
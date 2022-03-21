namespace ExemploPOO.Models
{
    public abstract class Account
    {
        protected double balance;

        public abstract void Credit(double value);

        public void ShowBalance()
        {
            System.Console.WriteLine("Your balance is: " + balance);
        }
    }
}
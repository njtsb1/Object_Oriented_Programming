namespace ExemploPOO.Models
{
    public class Current : Account
    {
        public override void Credit(double value)
        {
            base.balance = value;
        }
    }
}
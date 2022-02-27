namespace Supermarket
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            return Price * (1+(decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue.........: {$"{ValueToPay():C2}", 18}";
        }
    }
}

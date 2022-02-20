namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity * (1 + (decimal)Tax) ;
        }
        public override string ToString()
        {
            return $" {Id} - {Description}" +
                $"\n\tMeasurement...: {$"{Measurement}"}" +
                $"\n\tQuantity......: {$"{Quantity:N2}",18}" +
                $"\n\tPrice.........: {$"{Price:c2}",18}" +
                $"\n\tTax...........: {$"{Tax:P2}",18}"+
                $"\n\tValue.........: {$"{ValueToPay():c2}",18}";
        }
    }
}

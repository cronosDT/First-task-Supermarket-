namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public  List<Product>  Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in Products)
            { 
                payroll += product.ValueToPay();
            };
            return payroll - (payroll * (decimal)Discount);
        }
        public override string ToString()
        {
            List<string> products = new List<string>();
            Products.ForEach((product) => { products.Add(product.Description); });
            return $"  {Id}  {Description}" +
                $"\n\tProducts......: {string.Join(", ",products)}" +
                $"\n\tDiscount......: {$"{Discount:P2}",18}" +
                $"\n\tValue.........: {$"{ValueToPay():C2}",18}";
        }
    }
}

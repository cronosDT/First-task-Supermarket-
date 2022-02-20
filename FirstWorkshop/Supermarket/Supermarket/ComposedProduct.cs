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

        public string ProductName()
        {
            string productsName = "";
            foreach (Product product in Products)
            {
                productsName += product.Description + ", ";
            };
            return productsName;
        }

        public override string ToString()
        {
            return $" {Id} - {Description}" +
                $"\n\tProducts......: {ProductName()}" +
                $"\n\tDiscount......: {$"{Discount:P2}",18}" +
                $"\n\tValue.........: {$"{ValueToPay():C2}",18}";
        }
    }
}

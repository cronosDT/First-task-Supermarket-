namespace Supermarket
{
    public class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }
        public Product AddProduct(Product newPeoduct)
        {
            _products.Add(newPeoduct);
            return newPeoduct;
        }
        public decimal ValueToPay()
        {
            decimal value = 0;
            foreach (Product product in _products)
            {
                value += product.ValueToPay();
            }
            return value;
        }

        public override string ToString()
        {
            return $"RECEIPT" +
                $"\n------------------------------------------------- " +
                $"\n{string.Join("\n",_products)}" +
                $"\n                        ==================" +
                $"\nTOTAL:                  {$"{ValueToPay():C2}",18}";
        }
    }
}

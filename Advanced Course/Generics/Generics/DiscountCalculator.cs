namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        Product
    }

    public class Product
    {
        public double price { get; set; }
        public string title { get; set; }
    }
}
namespace FactoryDP.products
{
    public class UKRacket : IProduct
    {
        public string name { get; set; }
        public double price { get; set; }
        public double discount { get; set; }

        public UKRacket(string n, double p, double d)
        {
            name = n;
            price = p;
            discount = d;
        }

        public string getProductInfo()
        {
            return $"Name: {name}\nPrice: {price}\nDiscount: {discount}%\nDiscounted price: {calculate.CalculateDiscountedPrice(price, discount)}";
        }
    }
}

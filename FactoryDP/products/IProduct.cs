namespace FactoryDP.products
{
    public interface IProduct
    {
        string name { get; set; }
        double price { get; set; }
        double discount { get; set; }
        string getProductInfo();
    }
}

using FactoryDP.products;

namespace FactoryDP
{
    public interface IProductsFactory
    {
        IProduct CreateBall(string name, double price, double discount);
        IProduct CreateRacket(string name, double price, double discount);
        IProduct CreateShoes(string name, double price, double discount);
    }
}

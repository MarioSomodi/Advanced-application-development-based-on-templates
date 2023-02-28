using FactoryDP.products;

namespace FactoryDP
{
    public class UKProductFactory : IProductsFactory
    {
        public IProduct CreateBall(string name, double price, double discount)
        {
            return new UKBall(name, price, discount);
        }

        public IProduct CreateRacket(string name, double price, double discount)
        {
            return new UKRacket(name, price, discount);
        }

        public IProduct CreateShoes(string name, double price, double discount)
        {
            return new UKShoes(name, price, discount);
        }
    }
}

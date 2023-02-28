using FactoryDP.products;

namespace FactoryDP
{
    public class USProductFactory : IProductsFactory
    {
        public IProduct CreateBall(string name, double price, double discount)
        {
            return new USBall(name, price, discount);
        }

        public IProduct CreateRacket(string name, double price, double discount)
        {
            return new USRacket(name, price, discount);
        }

        public IProduct CreateShoes(string name, double price, double discount)
        {
            return new USShoes(name, price, discount);
        }
    }
}

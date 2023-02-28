using FactoryDP.products;

namespace FactoryDP
{
    class Client
    {
        static void Main(string[] args)
        {
            int store;
            string[] productInfo = Server.getProducts();
            IProductsFactory Factory = null!;
            IProduct product = null!;

            do
            {
                Console.WriteLine("Please select your store:");
                Console.WriteLine("[1]UK store, [2]US store");
                int.TryParse(Console.ReadLine(), out store);
            }
            while (store <= 0 || store > 2);

            switch (store)
            {
                case 1:
                    Factory = new UKProductFactory();
                    break;
                case 2:
                    Factory = new USProductFactory();
                    break;
            }

            switch (productInfo[0])
            {
                case "ball":
                    product = Factory.CreateBall(productInfo[0], Convert.ToDouble(productInfo[1]), Convert.ToDouble(productInfo[2]));
                    break;
                case "racket":
                    product = Factory.CreateRacket(productInfo[0], Convert.ToDouble(productInfo[1]), Convert.ToDouble(productInfo[2]));
                    break;
                case "shoes":
                    product = Factory.CreateShoes(productInfo[0], Convert.ToDouble(productInfo[1]), Convert.ToDouble(productInfo[2]));
                    break;
            }

            while (true)
            {
                int milliseconds = 5000;
                Console.WriteLine(product.getProductInfo());
                Console.WriteLine(Logger.getLogMessage(product.name, product.discount));
                Thread.Sleep(milliseconds);
            }
        }
    }
}

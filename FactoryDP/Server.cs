namespace FactoryDP
{
    public static class Server
    {
        public static string[] getProducts()
        {
            string products = File.ReadAllText("D:\\Faks\\Cetvrta_Godina\\Prvi_semestar\\Napredni_razvoj_aplikacija_koristenjem_obrazaca\\Labs\\AADBT\\FactoryDP\\products.txt");
            var productInfo = products.Split(';');
            return productInfo;
        }
    }
}

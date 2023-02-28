namespace AdapterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("HP Omen");
            Charger charger = new Charger();
            IEuSocket socketEU = new StandardEuSocket();
            IGbSocket socketGB = new StandardGbSocket();
            AdapterGBToEU adapterDP = new AdapterGBToEU(socketGB);
            charger.charge(laptop, socketEU);
            charger.charge(laptop, adapterDP);
        }
    }
}

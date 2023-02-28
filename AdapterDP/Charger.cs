namespace AdapterDP
{
    public class Charger
    {
        public void charge(Laptop laptop, IEuSocket euSocket)
        {
            Console.WriteLine($"Charging laptop {laptop.getName()} with {euSocket.giveEuCurrent()}");
        }
    }
}

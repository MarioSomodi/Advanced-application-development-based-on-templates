namespace ObserverDP
{
    public class Subscriber : ISubscriber
    {
        private readonly string _name;
        public Subscriber(string name)
        {
            _name = name;
        }
        public void Update(object? value, string action)
        {
            Console.WriteLine($"Notifing {_name} \nTime action was performe: {DateTime.UtcNow.ToLongTimeString()} \nAction: {action} \nValue: {value?.ToString()}\n");
        }
    }
}

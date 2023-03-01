namespace ObserverDP
{
    public interface ISubscriber
    {
        void Update(object? value, string action);
    }
}

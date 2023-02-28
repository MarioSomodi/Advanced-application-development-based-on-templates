namespace ObjectPoolDP.ObjectStores
{
    public interface IObjectStore<T>
    {
        T Fetch();
        void Store(T obj);
        int Count { get; }
    }
}

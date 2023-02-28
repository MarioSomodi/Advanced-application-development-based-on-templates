namespace ObjectPoolDP.ObjectStores
{
    public class QueueStore<T> : Queue<T>, IObjectStore<T>
    {
        public QueueStore(int capacity) : base(capacity)
        { }
        public T Fetch()
        {
            return Dequeue();
        }
        public void Store(T obj)
        {
            Enqueue(obj);
        }
    }
}

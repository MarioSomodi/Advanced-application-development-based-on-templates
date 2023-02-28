namespace ObjectPoolDP.ObjectStores
{
    public class StackStore<T> : Stack<T>, IObjectStore<T>
    {
        public StackStore(int capacity) : base(capacity)
        { }

        public T Fetch()
        {
            return Pop();
        }

        public void Store(T item)
        {
            Push(item);
        }
    }
}

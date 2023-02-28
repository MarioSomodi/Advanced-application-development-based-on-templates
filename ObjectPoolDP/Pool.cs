using ObjectPoolDP.ObjectStores;
using System;
using System.Diagnostics;
using System.Threading;

namespace ObjectPoolDP
{
    public enum AccessMode { FIFO, LIFO };
    public enum LoadingMode { Lazy, Eager };

    public class Pool<T> : IDisposable
    {
        private bool isDisposed;
        private Factory<T> factory;
        private LoadingMode loadingMode;
        private IObjectStore<T> objectStore;
        private int size;
        private int count;
        private Semaphore sync;
        public bool IsDisposed
        {
            get { return isDisposed; }
        }

        public Pool(int size, Factory<T> factory, LoadingMode loadingMode, AccessMode accessMode)
        {
            if (size <= 0)
                throw new ArgumentOutOfRangeException("size", size,
                    "Argument 'size' must be greater than zero.");
            if (factory == null)
                throw new ArgumentNullException("Factory must be specified.");
            this.size = size;
            this.factory = factory;
            sync = new Semaphore(size, size);
            this.loadingMode = loadingMode;
            this.objectStore = CreateObjectStore(accessMode, size);
            if (loadingMode == LoadingMode.Eager)
            {
                PreloadItems();
            }
        }

        private IObjectStore<T> CreateObjectStore(AccessMode mode, int capacity)
        {
            switch (mode)
            {
                case AccessMode.FIFO:
                    return new QueueStore<T>(capacity);
                case AccessMode.LIFO:
                    return new StackStore<T>(capacity);
                default:
                    Debug.Assert(mode == AccessMode.FIFO,
                        "Invalid AccessMode in CreateObjectStore");
                    return new QueueStore<T>(capacity);
            }
        }

        private T AcquireEager()
        {
            lock (objectStore)
            {
                return objectStore.Fetch();
            }
        }

        private void PreloadItems()
        {
            for (int i = 0; i < size; i++)
            {
                T item = factory.getObj();
                objectStore.Store(item);
            }
            count = size;
        }

        private T AcquireLazy()
        {
            lock (objectStore)
            {
                if (objectStore.Count > 0)
                {
                    return objectStore.Fetch();
                }
            }
            Interlocked.Increment(ref count);
            return factory.getObj();
        }

        public T Acquire()
        {
            sync.WaitOne();
            switch (loadingMode)
            {
                case LoadingMode.Eager:
                    return AcquireEager();
                case LoadingMode.Lazy:
                    return AcquireLazy();
                default:
                    Debug.Assert(loadingMode == LoadingMode.Lazy,
                        "Unknown LoadingMode encountered in Acquire method.");
                    return AcquireLazy();
            }
        }

        public void Release(T item)
        {
            lock (objectStore)
            {
                objectStore.Store(item);
            }
            sync.Release();
        }

        public void Dispose()
        {
            if (isDisposed)
            {
                return;
            }
            isDisposed = true;
            if (typeof(IDisposable).IsAssignableFrom(typeof(T)))
            {
                lock (objectStore)
                {
                    while (objectStore.Count > 0)
                    {
                        IDisposable disposable = (IDisposable)objectStore.Fetch();
                        disposable.Dispose();
                    }
                }
            }
            sync.Close();
        }
    }
}

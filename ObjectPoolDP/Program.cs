using ObjectPoolDP.Models;

namespace ObjectPoolDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory<IPerson> personFactory = new Factory<IPerson>();
            Pool<IPerson> pool = new Pool<IPerson>(10, personFactory, LoadingMode.Lazy, AccessMode.LIFO);
            IPerson person = pool.Acquire();
            person.Hello();
            pool.Release(person);
            pool.Dispose();
            Console.Read();
        }
    }
}

namespace ObjectPoolDP.Models
{
    public class Person : IPerson
    {
        private static int count = 0;

        private int num;

        public Person()
        {
            num = Interlocked.Increment(ref count);
        }

        public void Dispose()
        {
            Console.WriteLine("Bye #{0} person", num);
        }

        public void Hello()
        {
            Console.WriteLine("Hi from #{0} person", num);
        }
    }
}

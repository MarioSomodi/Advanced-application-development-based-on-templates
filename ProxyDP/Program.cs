namespace ProxyDP
{
    class Program
    {
        static void someFunction(IUserRepository repo)
        {
            repo.updateAllBornAfter(2000);
        }
        static void Main(string[] args)
        {
            DefaultUserRepository repo = new DefaultUserRepository();
            Proxy proxy = new Proxy(repo);
            someFunction(proxy);
        }
    }
}

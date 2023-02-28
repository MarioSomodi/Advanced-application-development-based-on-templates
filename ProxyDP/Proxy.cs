namespace ProxyDP
{
    public class Proxy : IUserRepository
    {
        private DefaultUserRepository _defaultUserRepository;
        public Proxy(DefaultUserRepository defaultUserRepository)
        {
            _defaultUserRepository = defaultUserRepository;
        }

        public void updateAllBornAfter(int year)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    _defaultUserRepository.updateAllBornAfter(year);
                    Console.WriteLine("Updated all born after " + year);
                    break;
                }
                catch (DeadlockException ex)
                {
                    _ = ex;
                    Console.WriteLine("Deadlock happened, proxy handeled it and is retrying");
                    Thread.Sleep(300);
                };
            }
        }
    }
}

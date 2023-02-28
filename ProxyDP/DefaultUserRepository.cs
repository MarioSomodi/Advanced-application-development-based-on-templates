namespace ProxyDP
{
    public class DefaultUserRepository : IUserRepository
    {
        public void updateAllBornAfter(int year)
        {
            if (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond % 2 == 0) throw new DeadlockException();
        }
    }
}

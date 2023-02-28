namespace ProxyDP
{
    [Serializable]
    public class DeadlockException : Exception
    {
        public DeadlockException() { }

        public DeadlockException(string message)
            : base(message) { }

        public DeadlockException(string message, Exception inner)
            : base(message, inner) { }
    }
}

namespace AdapterDP
{
    public class AdapterGBToEU : IEuSocket
    {
        private readonly IGbSocket _standardGbSocket;

        public AdapterGBToEU(IGbSocket standardGbSocket)
        {
            this._standardGbSocket = standardGbSocket;
        }

        public string giveEuCurrent()
        {
            Console.WriteLine("Converting GB current to EU current");
            return _standardGbSocket.giveGbCurrent();
        }
    }
}

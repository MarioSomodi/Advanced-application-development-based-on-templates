namespace FactoryDP
{
    public static class Logger
    {
        public static string getLogMessage(string name, double discount)
        {
            return $"{DateTime.Now};{name};{Convert.ToInt32(discount)}%";
        }
    }
}

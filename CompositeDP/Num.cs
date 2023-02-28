namespace CompositeDP
{
    public class Num : IAction
    {
        private double x;

        public Num(double num)
        {
            x = num;
        }

        public void appendChild(IAction action)
        {
            Console.WriteLine("Forbidden");
        }

        public double calculate()
        {
            return x;
        }

        public void removeChild(IAction action)
        {
            Console.WriteLine("Forbidden");
        }
    }
}

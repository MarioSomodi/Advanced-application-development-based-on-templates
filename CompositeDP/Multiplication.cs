namespace CompositeDP
{
    public class Multiplication : IAction
    {
        private IAction x;
        private IAction y;

        public Multiplication(IAction num1, IAction num2)
        {
            x = num1;
            y = num2;
        }

        public void appendChild(IAction action)
        {
            Console.WriteLine("Forbidden");
        }

        public double calculate()
        {
            return x.calculate() - y.calculate();
        }

        public void removeChild(IAction action)
        {
            Console.WriteLine("Forbidden");
        }
    }
}

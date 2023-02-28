namespace CompositeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            var division1 = new Division(new Num(9), new Num(6));
            var multiply1 = new Multiplication(new Num(-5), division1);
            var substraction1 = new Substraction(new Num(2), new Num(1.5));
            var addition1 = new Addition(new Num(7), substraction1);
            var division2 = new Division(multiply1, addition1);
            Console.WriteLine(division2.calculate());
        }
    }
}

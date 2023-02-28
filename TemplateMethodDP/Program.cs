namespace TemplateMethodDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Maker coffeeMaker = new CoffeMaker();
            Maker teaMaker = new TeaMaker();

            coffeeMaker.Make();
            teaMaker.Make();
        }
    }
}

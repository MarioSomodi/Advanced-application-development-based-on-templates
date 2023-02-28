namespace TemplateMethodDP
{
    public class TeaMaker : Maker
    {
        public override void addAdditionalIngridients()
        {
            Console.WriteLine("Add lemon");
        }

        public override void addMainIngridientToPreperedWater()
        {
            Console.WriteLine("Steep tea in boiling water");
        }

        public override void fillCup()
        {
            Console.WriteLine("Pour tea in cup");
        }
    }
}

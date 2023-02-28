namespace TemplateMethodDP
{
    public class CoffeMaker : Maker
    {
        public override void addAdditionalIngridients()
        {
            Console.WriteLine("Add sugar and milk");
        }

        public override void addMainIngridientToPreperedWater()
        {
            Console.WriteLine("Brew coffee in boiling water");
        }

        public override void fillCup()
        {
            Console.WriteLine("Pour coffee in cup");
        }
    }
}

namespace TemplateMethodDP
{
    public abstract class Maker
    {
        public void prepareWaterForBeverage()
        {
            Console.WriteLine("Boil water");
        }
        public abstract void addMainIngridientToPreperedWater();
        public abstract void fillCup();
        public abstract void addAdditionalIngridients();

        public void Make()
        {
            prepareWaterForBeverage();
            addMainIngridientToPreperedWater();
            fillCup();
            addAdditionalIngridients();
        }
    }
}

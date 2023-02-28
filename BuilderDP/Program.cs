namespace BuilderDP
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            var burger = mealBuilder.NameOfTheMeal("Hamburger")
                                    .AddIngridient("Bun")
                                    .AddIngridient("Letuce")
                                    .AddIngridient("Tomato")
                                    .AddIngridient("Meat")
                                    .AddIngridient("Bun")
                                    .ServeMeal();

            var chickenNuggets = mealBuilder.NameOfTheMeal("Chiken nuggets")
                                    .AddIngridient("Chicken nuggets")
                                    .AddIngridient("Ketchup")
                                    .ServeMeal();

            PresentServedMeal(burger);
            PresentServedMeal(chickenNuggets);
        }

        public static void PresentServedMeal(ServedMeal meal)
        {
            Console.WriteLine($"Name of meal: {meal.name}");
            Console.WriteLine("Ingridients: ");
            foreach(var ingridient in meal.ingridients)
            {
                Console.WriteLine(ingridient);
            }
        }
    }
}

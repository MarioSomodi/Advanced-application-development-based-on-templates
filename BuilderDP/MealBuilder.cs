namespace BuilderDP
{
    public class MealBuilder
    {
        private ServedMeal meal = new ServedMeal();
        public MealBuilder NameOfTheMeal(string mealName)
        {
            meal.name = mealName;
            return this;
        }
        public MealBuilder AddIngridient(string ingridient)
        {
            meal.ingridients.Add(ingridient);
            return this;
        }
        public ServedMeal ServeMeal()
        {
            var m = meal;
            meal = new ServedMeal();
            return m;
        }
    }
}

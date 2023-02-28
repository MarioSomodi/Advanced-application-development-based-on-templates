namespace StrategyDP
{
    public class StudentBubbleSort : SortStrategy<Student>
    {
        public override void Sort(List<Student> list)
        {
            var tempValue = new Student();
            for (int currentIndex = 0; currentIndex <= list.Count - 2; currentIndex++)
            {
                for (int changingIndex = 0; changingIndex <= list.Count - 2; changingIndex++)
                {
                    if (list[changingIndex].CompareTo(list[changingIndex + 1]) > 0)
                    {
                        tempValue = list[changingIndex + 1];
                        list[changingIndex + 1] = list[changingIndex];
                        list[changingIndex] = tempValue;
                    }
                }
            }
        }
    }
}

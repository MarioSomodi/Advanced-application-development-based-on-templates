namespace StrategyDP
{
    public class StudentInsertionSort : SortStrategy<Student>
    {
        public override void Sort(List<Student> list)
        {
            for (int start = 1; start < list.Count; start++)
            {
                var tempValue = list[start];
                int flag = 0;
                for (int changeableIndex = start - 1; changeableIndex >= 0 && flag != 1;)
                {
                    if (tempValue.CompareTo(list[changeableIndex]) < 0)
                    {
                        list[changeableIndex + 1] = list[changeableIndex];
                        changeableIndex--;
                        list[changeableIndex + 1] = tempValue;
                    }
                    else flag = 1;
                }
            }
        }
    }
}

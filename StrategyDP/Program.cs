namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            SortableList<Student> studentRecords = new SortableList<Student>();
            studentRecords.Add(new Student("Samual", 1));
            studentRecords.Add(new Student("Rick", 5));
            studentRecords.Add(new Student("Anna", 2));
            studentRecords.Add(new Student("Mich", 4));
            studentRecords.Add(new Student("Miheal", 3));
            studentRecords.SetSortStrategy(new StudentInsertionSort());
            studentRecords.Sort();
            studentRecords.display();
        }
    }
}

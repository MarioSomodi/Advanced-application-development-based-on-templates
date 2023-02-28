namespace StrategyDP
{
    public class SortableList<T>
    {
        private List<T> _list = new List<T>();
        private SortStrategy<T> _sortStrategy;

        public void SetSortStrategy(SortStrategy<T> sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(T entity)
        {
            _list.Add(entity);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);
        }

        public void display()
        {
            foreach (T t in _list)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}

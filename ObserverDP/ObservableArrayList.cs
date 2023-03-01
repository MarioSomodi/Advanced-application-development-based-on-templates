using System.Collections;

namespace ObserverDP
{
    public abstract class ObservableArrayList
    {
        private ArrayList _arrayList = new();
        private List<ISubscriber> _subscribers = new();

        public ArrayList Add(object? value)
        {
            _arrayList.Add(value);
            Notify(value, nameof(Add));
            return _arrayList;
        }

        public ArrayList Remove(object? value)
        {
            _arrayList.Remove(value);
            Notify(value, nameof(Remove));
            return _arrayList;
        }

        public ArrayList Update(object? value, int index)
        {
            _arrayList.RemoveAt(index);
            _arrayList.Insert(index, value);
            Notify(value, nameof(Update));
            return _arrayList;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify(object? value, string action)
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update(value, action);
            }
        }
    }
}

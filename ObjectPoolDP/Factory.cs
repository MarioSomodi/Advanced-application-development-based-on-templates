using ObjectPoolDP.Models;
using System.Reflection;

namespace ObjectPoolDP
{
    public class Factory<T>
    {
        public T getObj()
        {
            Type iLoadType = (from t in Assembly.Load("ObjectPoolDP").GetExportedTypes()
                              where !t.IsInterface && !t.IsAbstract
                              where typeof(IPerson).IsAssignableFrom(t)
                              select t).First();
            return (T)Activator.CreateInstance(iLoadType);
        }
    }
}

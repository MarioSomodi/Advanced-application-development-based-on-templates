namespace CompositeDP
{
    public interface IAction
    {
        double calculate();
        void appendChild(IAction action);
        void removeChild(IAction action);
    }
}

namespace FacadeDP
{
    public class PopcornPopper : IPopcornPopper
    {
        public void TurnOnPopper()
        {
            Console.WriteLine("Popper has been turned on");
        }
        public void MakePopcorn()
        {
            Console.WriteLine("Make popcorn");
        }
        public void TurnOffPopper()
        {
            Console.WriteLine("Popper has been turned off");
        }
    }
}

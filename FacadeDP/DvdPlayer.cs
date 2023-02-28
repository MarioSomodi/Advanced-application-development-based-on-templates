namespace FacadeDP
{
    public class DvdPlayer : IDvdPlayer
    {
        public void TurnOn()
        {
            Console.WriteLine("DVD player turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("DVD player turned off");
        }
    }
}

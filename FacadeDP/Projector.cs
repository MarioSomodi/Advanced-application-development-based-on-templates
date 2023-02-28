namespace FacadeDP
{
    public class Projector : IProjector
    {
        public void TurnOn()
        {
            Console.WriteLine("Projector turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Projector turned off");
        }
        public void SetProjectorToDVD()
        {
            Console.WriteLine("Projector set to DVD");
        }
    }
}

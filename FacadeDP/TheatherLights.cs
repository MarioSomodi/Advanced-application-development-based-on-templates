namespace FacadeDP
{
    public class TheatherLights : ITheatherLights
    {
        public void TurnOn()
        {
            Console.WriteLine("Theather lights turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Theather lights turned off");
        }
        public void DimLights()
        {
            Console.WriteLine("Theather lights dimmed");
        }
    }
}

namespace FacadeDP
{
    public class Amplifier : IAmplifier
    {
        public void TurnOn()
        {
            Console.WriteLine("Amplifier turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Amplifier turned off");
        }
        public void SetAmplifierToDVD()
        {
            Console.WriteLine("Amplifier set to DVD");
        }
    }
}

namespace FacadeDP
{
    public class Screen : IScreen
    {
        public void LowerScreen()
        {
            Console.WriteLine("Screen lowered");
        }
        public void PullUpScreen()
        {
            Console.WriteLine("Screen pulled up");
        }
    }
}

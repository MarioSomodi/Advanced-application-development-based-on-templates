namespace FacadeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Home_Theather_System hTS = new Home_Theather_System();

            Console.WriteLine("Opening theather for movie watching");

            hTS.setupTheatherForMovieWatching();

            Console.WriteLine("Closing theather");
            
            hTS.closeTheatherAfterMovieWatching();

            Console.Read();
        }
    }
}

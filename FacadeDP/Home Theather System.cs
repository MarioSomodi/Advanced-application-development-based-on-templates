namespace FacadeDP
{
    public class Home_Theather_System
    {
        private IAmplifier amplifier;
        private IDvdPlayer dvdPlayer;
        private IPopcornPopper popcornPopper;
        private IProjector projector;
        private IScreen screen;
        private ITheatherLights theatherLights;
        public Home_Theather_System()
        {
            amplifier = new Amplifier();
            dvdPlayer = new DvdPlayer();
            popcornPopper = new PopcornPopper();
            projector = new Projector();
            screen = new Screen();
            theatherLights = new TheatherLights();
        }

        public void setupTheatherForMovieWatching()
        {
            theatherLights.TurnOn();
            popcornPopper.TurnOnPopper();
            popcornPopper.MakePopcorn();
            screen.LowerScreen();
            projector.TurnOn();
            dvdPlayer.TurnOn();
            projector.SetProjectorToDVD();
            amplifier.TurnOn();
            amplifier.SetAmplifierToDVD();
            theatherLights.DimLights();
        }

        public void closeTheatherAfterMovieWatching()
        {
            theatherLights.TurnOff();
            popcornPopper.TurnOffPopper();
            screen.PullUpScreen();
            projector.TurnOff();
            dvdPlayer.TurnOff();
            amplifier.TurnOff();
        }
    }
}

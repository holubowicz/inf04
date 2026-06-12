namespace ConsoleApp
{
    public class Odkurzacz : Urzadzenie
    {
        private bool _stan = false;

        public void On()
        {
            if (_stan)
            {
                return;
            }

            _stan = true;
            WyswietlKomunikat("Odkurzacz włączono");
        }

        public void Off()
        {
            if (!_stan)
            {
                return;
            }

            _stan = false;
            WyswietlKomunikat("Odkurzacz wyłączono");
        }
    }
}
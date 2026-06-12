namespace ConsoleApp
{
    public class Pralka : Urzadzenie
    {
        private int _programPrania = 0;

        public int UstawProgramPrania(int programPrania)
        {
            _programPrania = programPrania >= 1 && programPrania <= 12
                ? programPrania
                : 0;
            return _programPrania;
        }
    }
}
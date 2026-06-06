namespace ConsoleApp
{
    public class Osoba
    {
        public static int LiczbaInstancji { get; private set; } = 0;

        private int _id;
        private string _imie;

        public Osoba()
        {
            _id = 0;
            _imie = string.Empty;
            LiczbaInstancji++;
        }

        public Osoba(int id, string imie)
        {
            _id = id;
            _imie = imie;
            LiczbaInstancji++;
        }

        public Osoba(Osoba osoba)
        {
            _id = osoba._id;
            _imie = osoba._imie;
            LiczbaInstancji++;
        }

        public void PrzywitajSie(string imie)
        {
            if (string.IsNullOrEmpty(_imie))
            {
                Console.WriteLine("Brak danych");
                return;
            }

            Console.WriteLine($"Cześć {imie}, mam na imię {_imie}");
        }
    }
}
namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Pralka pralka = new Pralka();
            Odkurzacz odkurzacz = new Odkurzacz();

            int programPrania;
            while (true)
            {
                Console.WriteLine("Podaj numer prania 1..12");
                if (int.TryParse(Console.ReadLine() ?? string.Empty, out programPrania))
                {
                    break;
                }
            }

            int ustawionyProgram = pralka.UstawProgramPrania(programPrania);
            Console.WriteLine(
                ustawionyProgram == 0
                    ? "Podano niepoprawny numer programu"
                    : "Program został ustawiony"
            );

            odkurzacz.On();
            odkurzacz.On();
            odkurzacz.On();
            odkurzacz.WyswietlKomunikat("Odkurzacz wyładował się");
            odkurzacz.Off();
        }
    }
}
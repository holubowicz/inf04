namespace ConsoleApp
{
    internal class Program
    {
        private static readonly string Filepath = Path.GetFullPath("Data.txt");
        private static readonly int FieldsCount = 5;

        private static List<MusicAlbum> _albums = new List<MusicAlbum>();

        internal static void Main(string[] args)
        {
            LoadAlbums();
            
            foreach (MusicAlbum album in _albums)
            {
                Console.WriteLine(album);
            }
        }

        /**********************************************
        nazwa funkcji:       LoadAlbums
        opis funkcji:        Ładuje dane z pliku o albumach muzycznych do listy albumów.
        parametry:           brak
        zwracany typ i opis: brak
        autor:               00000000000
        ***********************************************/
        private static void LoadAlbums()
        {
            string[] lines = File.ReadAllLines(Filepath);
            MusicAlbum album = new MusicAlbum();
            
            int fieldIndex = 0;
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    _albums.Add(album);
                    album = new MusicAlbum();
                    continue;
                }

                if (fieldIndex == 0)
                {
                    album.Artist = line;
                }
                else if (fieldIndex == 1)
                {
                    album.Album = line;
                }
                else if (fieldIndex == 2)
                {
                    album.SongsNumber = int.Parse(line);
                }
                else if (fieldIndex == 3)
                {
                    album.Year = int.Parse(line);
                }
                else if (fieldIndex == 4)
                {
                    album.DownloadNumber = int.Parse(line);
                }

                fieldIndex = (fieldIndex + 1) % FieldsCount;
            }

            if (!string.IsNullOrEmpty(album.Artist))
            {
                _albums.Add(album);
            }
        }
    }
}
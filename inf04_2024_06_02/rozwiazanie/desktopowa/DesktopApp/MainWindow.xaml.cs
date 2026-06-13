using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly string Filepath = Path.GetFullPath("Data.txt");
        private static readonly int FieldsCount = 5;

        private List<MusicAlbum> _albums = new List<MusicAlbum>();
        private int _albumIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            LoadAlbums();
            UpdateAlbumInfo();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            int count = _albums.Count;
            _albumIndex = (_albumIndex + count - 1) % count;
            UpdateAlbumInfo();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            int count = _albums.Count;
            _albumIndex = (_albumIndex + 1) % count;
            UpdateAlbumInfo();
        }

        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            MusicAlbum album = _albums[_albumIndex];
            album.DownloadNumber++;
            UpdateAlbumInfo();
        }

        private void UpdateAlbumInfo()
        {
            MusicAlbum album = _albums[_albumIndex];

            ArtistLabel.Content = album.Artist;
            AlbumLabel.Content = album.Album;
            SongsNumberLabel.Content = $"{album.SongsNumber} utworów";
            YearLabel.Content = album.Year;
            DownloadNumberLabel.Content = album.DownloadNumber;
        }

        private void LoadAlbums()
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
using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly int LettersCount = 26;

        private string _result = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            if (!int.TryParse(KeyTextBox.Text, out int key))
            {
                key = 0;
                KeyTextBox.Text = key.ToString();
            }

            _result = CaesarCipher(input, key);
            ResultTextBlock.Text = _result;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if ((bool)saveFileDialog.ShowDialog())
            {
                string path = saveFileDialog.FileName;
                File.WriteAllText(path, _result);
            }
        }

        private string CaesarCipher(string input, int key)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            int shift = (key % LettersCount + LettersCount) % LettersCount;

            StringBuilder cipher = new StringBuilder();
            foreach (char character in input)
            {
                if (character >= 'a' && character <= 'z')
                {
                    int newCharacter = (character - 'a' + shift) % LettersCount + 'a';
                    cipher.Append((char)newCharacter);
                    continue;
                }

                cipher.Append(character);
            }

            return cipher.ToString();
        }
    }
}
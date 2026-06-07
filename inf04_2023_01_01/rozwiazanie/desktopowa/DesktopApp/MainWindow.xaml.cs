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
        private static readonly string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string UppercaseLetters = LowercaseLetters.ToUpper();
        private static readonly string Digits = "0123456789";
        private static readonly string SpecialCharacters = "!@#$%^&*()_+-=";

        private readonly Random Rand = new Random();

        private string _password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GeneratePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(PasswordLengthTextBox.Text, out int passwordLength))
            {
                MessageBox.Show("Podaj ilość znaków, która będzie dodatnią liczbą całkowitą");
                return;
            }

            bool isLowercaseAndUppercase = (bool)LowercaseAndUppercaseCheckBox.IsChecked;
            bool isDigits = (bool)DigitsCheckBox.IsChecked;
            bool isSpecialCharacters = (bool)SpecialCharactersCheckBox.IsChecked;

            int optionsNumber = 0;
            if (isLowercaseAndUppercase) optionsNumber++;
            if (isDigits) optionsNumber++;
            if (isSpecialCharacters) optionsNumber++;

            if (passwordLength < optionsNumber)
            {
                MessageBox.Show($"Podano za krótką ilość znaków! Do wybranych opcji wymagana jest ilość przynajmniej {optionsNumber}");
                return;
            }

            StringBuilder charactersStringBuilder = new StringBuilder(LowercaseLetters);
            List<char> passwordCharacters = new List<char>();

            if (isLowercaseAndUppercase)
            {
                int index = Rand.Next(UppercaseLetters.Length);
                passwordCharacters.Add(UppercaseLetters[index]);

                charactersStringBuilder.Append(UppercaseLetters);
                passwordLength--;
            }

            if (isDigits)
            {
                int index = Rand.Next(Digits.Length);
                passwordCharacters.Add(Digits[index]);

                charactersStringBuilder.Append(Digits);
                passwordLength--;
            }

            if (isSpecialCharacters)
            {
                int index = Rand.Next(SpecialCharacters.Length);
                passwordCharacters.Add(SpecialCharacters[index]);

                charactersStringBuilder.Append(SpecialCharacters);
                passwordLength--;
            }

            string characters = charactersStringBuilder.ToString();
            while (passwordLength > 0)
            {
                int index = Rand.Next(characters.Length);
                passwordCharacters.Add(characters[index]);
                passwordLength--;
            }

            _password = string.Join("", passwordCharacters.Shuffle());
            MessageBox.Show(_password);
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Zanim zatwierdzisz dane, wygeneruj hasło!");
                return;
            }

            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string position = PositionComboBox.Text;

            MessageBox.Show($"Dane pracownika: {firstName} {lastName} {position} Hasło: {_password}");
        }
    }
}
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
        private string _selectedEyeColor = "niebieskie";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string number = textBox.Text;

            if (number != "000" && number != "111" && number != "333")
            {
                PersonImage.Visibility = Visibility.Collapsed;
                FingerprintImage.Visibility = Visibility.Collapsed;
                return;
            }

            PersonImage.Visibility = Visibility.Visible;
            PersonImage.Source = new BitmapImage(new Uri($"/Images/{number}-zdjecie.jpg", UriKind.Relative));

            FingerprintImage.Visibility = Visibility.Visible;
            FingerprintImage.Source = new BitmapImage(new Uri($"/Images/{number}-odcisk.jpg", UriKind.Relative));
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }

            MessageBox.Show($"{firstName} {lastName} kolor oczu {_selectedEyeColor}");
        }

        private void EyeColorRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            _selectedEyeColor = (string)radioButton.Content;
        }
    }
}
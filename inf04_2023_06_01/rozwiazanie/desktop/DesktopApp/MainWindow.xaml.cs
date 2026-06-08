using System.Globalization;
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
        public MainWindow()
        {
            InitializeComponent();
            UpdateShipmentType();
        }

        private void CheckPriceButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateShipmentType();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            string zipCode = ZipCodeTextBox.Text;

            if (zipCode.Length != 5)
            {
                MessageBox.Show(
                    "Nieprawidłowa liczba cyfr w kodzie pocztowym",
                    "Błąd",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            if (!int.TryParse(zipCode, out int _))
            {
                MessageBox.Show(
                    "Kod pocztowy powinien się składać z samych cyfr",
                    "Błąd",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            MessageBox.Show("Dane przesyłki zostały wprowadzone",
                "Informacja",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void UpdateShipmentType()
        {
            string imageName = "pocztowka";
            double price = 1;

            if ((bool)LetterRadioButton.IsChecked)
            {
                imageName = "list";
                price = 1.5;
            }
            else if ((bool)PackageRadioButton.IsChecked)
            {
                imageName = "paczka";
                price = 10;
            }

            ShipmentTypeImage.Source = new BitmapImage(new Uri($"/Images/{imageName}.png", UriKind.Relative));
            ShipmentPriceLabel.Content = $"Cena: {price.ToString(new CultureInfo("pl"))} zł";
        }
    }
}
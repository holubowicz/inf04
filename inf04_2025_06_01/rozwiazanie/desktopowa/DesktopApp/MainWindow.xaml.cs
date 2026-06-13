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
        private byte _red = 255;
        private byte _green = 255;
        private byte _blue = 255;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (RedColorLabel == null) return;

            _red = (byte)e.NewValue;
            RedColorLabel.Content = _red;

            UpdateColorRectangle();
        }

        private void GreenColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (GreenColorLabel == null) return;

            _green = (byte)e.NewValue;
            GreenColorLabel.Content = _green;

            UpdateColorRectangle();
        }

        private void BlueColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (BlueColorLabel == null) return;

            _blue = (byte)e.NewValue;
            BlueColorLabel.Content = _blue;

            UpdateColorRectangle();
        }

        private void SaveColorButton_Click(object sender, RoutedEventArgs e)
        {
            SaveColorLabel.Content = string.Join(", ", _red, _green, _blue);
            SaveColorLabel.Background = new SolidColorBrush(Color.FromRgb(_red, _green, _blue));
        }

        private void UpdateColorRectangle()
        {
            ColorRectangle.Fill = new SolidColorBrush(Color.FromRgb(_red, _green, _blue));
        }
    }
}
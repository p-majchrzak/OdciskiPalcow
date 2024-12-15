using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OdciskiPalcow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Regex sprawdzNazwisko = new Regex("^[A-Z]{1}[a-z]");
            if(sprawdzNazwisko.IsMatch(Nazwisko.Text))
            {
                string kolor = "";
                if (Zielone.IsChecked == true)
                {
                    kolor = "zielone";
                }
                if (Niebieskie.IsChecked == true)
                {
                    kolor = "niebieskie";
                }
                if (Piwne.IsChecked == true)
                {
                    kolor = "piwne";
                }
                MessageBox.Show($"{Imie.Text} {Nazwisko.Text} kolor oczu {kolor}");
            }
            else
            {
                MessageBox.Show("Nazwisko musi zaczynać się z dużej litery.");
            }
        }

        private void Numer_TextChanged(object sender, TextChangedEventArgs e)
        {
            Zdjecie.Source = new BitmapImage(new Uri($"{Numer.Text}-zdjecie.jpg", UriKind.RelativeOrAbsolute));
            Odcisk.Source = new BitmapImage(new Uri($"{Numer.Text}-odcisk.jpg", UriKind.RelativeOrAbsolute));
        }
    }
}
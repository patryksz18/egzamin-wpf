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

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ilosc_znakow;
        string haslo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_generuj_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(ile_znakow.Text, out ilosc_znakow);
            Random rnd = new Random();
            string[] litery = { "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM" };
            string[] cyfry = { "1234567890" };
            string[] znaki_specjalne = { "!@#$%^&*()_+-=" };
            for (int i = 0; i <= ilosc_znakow; i++)
            {
                if (litery_chb.IsChecked == true)
                {
                    haslo += litery[rnd.Next(litery.Length)];

                }
                else if (cyfry_chb.IsChecked == true) 
                {
                    haslo += cyfry[rnd.Next(cyfry.Length)];
                }
                else if (znaki_specjalne_chb.IsChecked == true)
                {
                    haslo += znaki_specjalne[rnd.Next(znaki_specjalne.Length)];
                }
            }
            MessageBox.Show(haslo);
        }

        private void btn_zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dane pracownika:" + imie.Text + " " + nazwisko.Text+ " " + stanowisko_combo.SelectedItem + " haslo:" + haslo );
        }
    }
}
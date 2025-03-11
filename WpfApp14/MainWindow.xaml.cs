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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_generuj_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(ile_znakow.Text, out ilosc_znakow);
            Random rnd = new Random();
            string litery = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string liczby = "1234567890";
            string znaki_specjalne = "!@#$%^&*()";
        }
    }
}
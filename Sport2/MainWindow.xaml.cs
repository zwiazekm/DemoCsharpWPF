using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sport2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZawodySportowe.Zawody biegi = new ZawodySportowe.Zawody();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NowyZawodnik_Click(object sender, RoutedEventArgs e)
        {
            DaneZawodnika oknoZawodnik = new DaneZawodnika();
            if (oknoZawodnik.ShowDialog().Value)
            {
                //TODO: Odczyt danych z okna
                int wiek = int.Parse( oknoZawodnik.txtWiek.Text);
                biegi.DodajZawodnika(
                    oknoZawodnik.txtImie.Text, oknoZawodnik.txtImie.Text, wiek);
                listaZawodnikow.ItemsSource = biegi.ListaZawodnikow();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}

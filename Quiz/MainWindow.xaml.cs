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

namespace Quiz
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

        private void DajPytanieButton_Click(object sender, RoutedEventArgs e)
        {
            //Pobierz pytanie
            string pytanie = "Wszystkie struktury oraz klasy są typami referencyjnymi?";
            //Wyświetl pytanie
            PytanieLabel.Content = pytanie;
            //Aktywuj kontrolki
            OdpowiedzCombo.IsEnabled = true;
            SprawdzButton.IsEnabled = true;
        }

        private void SprawdzButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (ComboBoxItem)OdpowiedzCombo.SelectedValue;
            string odp = selectedItem.Content.ToString();

            if (odp=="Fałsz")
            {
                ListaWynikow.Content += 
                    System.Environment.NewLine + //daje znak nowej linii
                    $"{PytanieLabel.Content} - Dobrze";
                WynikLabel.Content = "Brawo!!! Prawidłowa odpowiedź";
            }
            else
            {
                ListaWynikow.Content += 
                    System.Environment.NewLine + 
                    $"{PytanieLabel.Content} - Żle";
                WynikLabel.Content = "Źle!!! Spróbuj jeszcze raz.";
            }
            PytanieLabel.Content = "";
            OdpowiedzCombo.IsEnabled = false;
            SprawdzButton.IsEnabled = false;
            
        }
    }
}

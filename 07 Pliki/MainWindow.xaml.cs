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
using System.IO;

namespace _07_Pliki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = @"c:\DemoPliki\wiadomosci.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ZapiszButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string stringToSave =
                        System.Environment.NewLine + MessageTextBox.Text;
                //Tworzy plik i zapisuje dane tekstowe
                //File.WriteAllText(filePath, stringToSave);
                File.AppendAllText(filePath, stringToSave);
                MessageBox.Show("Zapisano", "Status zapisu",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                MessageTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BŁĄD",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //Tworzy nowy plik z pierwszą linią
                File.WriteAllText(filePath, "Lista komunkatów:");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BŁĄD", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OdczytajButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string loadedString = File.ReadAllText(filePath);
                KontentLabel.Content = loadedString;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "BŁĄD",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InfoPlikButton_Click(object sender, RoutedEventArgs e)
        {
            FileInfo file = new FileInfo(filePath);
            MessageBox.Show(
                $"Katalog: {file.DirectoryName}, Data utworznia: {file.CreationTime}", 
                "FIle Info");

        }

        private void TworzKatalogButton_Click(object sender, RoutedEventArgs e)
        {
            string nowyKatalog = NowKatalogTxt.Text;
            Directory.CreateDirectory(nowyKatalog);
            MessageBox.Show("Utworzono katalog");
        }
    }
}

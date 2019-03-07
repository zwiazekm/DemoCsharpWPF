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

namespace _05_WPFProject
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

        //Metoda obsługująca zdarzenie (EventHandler) przy kliknięciu. 
        private void BtnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF");
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            string info = InfoText.Text;
            InfoLabel.Content = info;
        }

        private void InfoCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selection = (ComboBoxItem)InfoCombo.SelectedItem;
            ComboInfoText.Text = selection.Content.ToString();
            ComboInfoText.Background = selection.Background;
        }
    }
}

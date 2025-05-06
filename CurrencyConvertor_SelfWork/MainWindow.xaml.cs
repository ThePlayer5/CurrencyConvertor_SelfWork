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

namespace CurrencyConvertor_SelfWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Transfer()
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                var selectedCurrency = (Convertor.SelectedItem as ComboBoxItem)?.Content.ToString();
                double result = 0;
                switch (selectedCurrency)
                {
                    case "USD":
                        result = double.Parse(Input.Text) / 90;
                        Output.Text = Math.Round(result, 2).ToString();
                        break;
                    case "EUR":
                        result = double.Parse(Input.Text) / 97;
                        Output.Text = Math.Round(result, 2).ToString();
                        break;
                    case "CNY":
                        result = double.Parse(Input.Text) / 12;
                        Output.Text = Math.Round(result, 2).ToString();
                        break;
                }
            }
        }

        private void Convertor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Transfer();
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            Transfer();
        }

        private void Output_TextChanged(object sender, TextChangedEventArgs e)
        {
            Transfer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Transfer();
        }
    }
}

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

namespace KamatosKamat
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int deposit_amount = int.Parse(tb_deposit.Text);
            double interest_rate = double.Parse(tb_interestrate.Text);

            // (1 + p / 100 ) ^ n          

            for (int i = 0; i < 51; i++)
            {
                double test = deposit_amount * Math.Pow((1 + interest_rate / 100), i);

                var output = new Output(i, test);
                lb.Items.Add(output);
            }
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lb.SelectedItem as Output;
            lb_output.Content = "$" + Math.Round(selected.Test / ( selected.I * 12 ),2);
        }
    }
}

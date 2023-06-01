using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POE
{
    /// <summary>
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void btn_enterRent_Click(object sender, RoutedEventArgs e)
        {
            txt_rentshow.Text = "Your Monthly Rental Amount is R" + txt_rentamount.Text;
        }

        private void btn_Proceed_Click(object sender, RoutedEventArgs e)
        {
            Choice cho = new Choice();
            this.Visibility = Visibility.Hidden;
            cho.Show();
        }

        private void txt_rentamount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
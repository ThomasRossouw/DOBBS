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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        public Savings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Variables
            double amt;
            double interest;
            double years;
            double months;

            //Parsing the textboxes
            amt = Double.Parse(txt_amount.Text);
            interest = Double.Parse(txt_Interest.Text);
            years = Double.Parse(txt_Years.Text);
            months = years * 12;



            try
            {
                txt_Results.Text = "The User Will Have To Save:" + "\nR" + ((amt * 1 + interest / 100 * years) / months).ToString("0.00");
            }
            catch
            {

            }

        
    }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            Services ser = new Services();
            this.Visibility = Visibility.Hidden;
            ser.Show();

        }

        private void txt_amount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Interest_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Years_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}

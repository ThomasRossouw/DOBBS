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
using System.Windows.Shapes;

namespace POE
{
    /// <summary>
    /// Interaction logic for Services.xaml
    /// </summary>
    public partial class Services : Window
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btn_Rental_Click(object sender, RoutedEventArgs e)
        {
            Rent re = new Rent();
            this.Visibility = Visibility.Hidden;
            re.Show();
        }

        private void btn_Bond_Click(object sender, RoutedEventArgs e)
        {
            Purchase pur = new Purchase();
            this.Visibility = Visibility.Hidden;
            pur.Show();
        }

        private void btn_Vehicle_Click(object sender, RoutedEventArgs e)
        {
            Vehicle veh = new Vehicle();
            this.Visibility = Visibility.Hidden;
            veh.Show();
        }

        private void btn_Savings_Click(object sender, RoutedEventArgs e)
        {
            Savings save = new Savings();
            this.Visibility = Visibility.Hidden;
            save.Show();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank You For Using DOBBS :)");
            this.Close();
        }
    }
}

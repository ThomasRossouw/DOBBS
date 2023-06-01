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
    /// Interaction logic for Choice.xaml
    /// </summary>
    public partial class Choice : Window
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, RoutedEventArgs e)
        {
            Vehicle veh = new Vehicle();
            this.Visibility = Visibility.Hidden;
            veh.Show();

        }

        private void btn_No_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank You For Using DOBBS :)");
            this.Close();
        }
    }
}

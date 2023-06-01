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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void btn_Calcu_Click(object sender, RoutedEventArgs e)
        {
            //variables
            //Variables for calc
            double purhcaseprice;
            double deposit;
            double interestrate;

            purhcaseprice = Double.Parse(txt_PurchasePrice.Text);
            deposit = Double.Parse(txt_Deposit.Text);
            interestrate = Double.Parse(txt_Interest.Text);



            try
            {
                txt_Monthly.Text = (((purhcaseprice - deposit) * 1 + interestrate / 100 * 5) / 60).ToString("0.00");


            }
            catch
            {
            }
            try
            {
                //MainWindow obj
                MainWindow mr = new MainWindow();

                txt_VehicleCar.Text = "                        Summary Output" + "\n" + "Groceries: R" + MainWindow.SetValueForText2 + "\nLights And Water: R" + MainWindow.SetValueForText3 + "\nCellphone: R" + MainWindow.SetValueForText4 + "\nTravel: R" + MainWindow.SetValueForText5 + "\nOthers: R" + MainWindow.SetValueForText6 + "\nVehicle Insurance: R" + txt_Insurance.Text;

                //calcs
                //total Expenses
                txt_box1.Text = "" + (float.Parse(txt_Monthly.Text) + float.Parse(MainWindow.SetValueForText2) + float.Parse(MainWindow.SetValueForText3) + float.Parse(MainWindow.SetValueForText4) + float.Parse(MainWindow.SetValueForText5) + float.Parse(MainWindow.SetValueForText6) + float.Parse(txt_Insurance.Text)).ToString();

                //portion of user income
                txt_Box2.Text = "" + (float.Parse(MainWindow.SetValueForText1) * 75 / 100).ToString();

                double a;
                double b;

                a = Double.Parse(txt_box1.Text);
                b = Double.Parse(txt_Box2.Text);
                if (a > b)
                {
                    MessageBox.Show("Alert: Car Finance Approval Is Highly Unlikely.");
                }
                else
                {
                    MessageBox.Show("Congratulations! Your Vehicle Finance has been Approved.");
                }
            }
            catch
            {

            }









        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Thank You For Using DOBBS :)");
            this.Close();

        }

        private void txtbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


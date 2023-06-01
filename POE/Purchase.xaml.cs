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
    /// Interaction logic for Purchase.xaml
    /// </summary>
    public partial class Purchase : Window
    {


        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            txt_USalary.Text = MainWindow.SetValueForText1;
        }

        private void btn_Calculation_Click(object sender, RoutedEventArgs e)
        {
            //Variables for calc
            double purhcaseprice;
            double deposit;
            double interestrate;
            double months;



            purhcaseprice = Double.Parse(txt_PriceProp.Text);
            deposit = Double.Parse(txt_DepositAmt.Text);
            interestrate = Double.Parse(txt_Interest.Text);
            months = Double.Parse(txt_Months.Text);


            try
            {
                txt_Before.Text = ((purhcaseprice - deposit) * 1 + interestrate / 100 * months / 12).ToString();

            }
            catch
            {

            }
            try
            {
                txt_pay.Text = "Monthly Payments:" + "\n" + "R" + ((float.Parse(txt_Before.Text)) / months).ToString("0.00");

            }
            catch
            {

            }

            txt_USalary.Text = MainWindow.SetValueForText1;

            try
            {
                double a;
                a = Double.Parse(txt_Before.Text) / months;
                double b;
                b = Double.Parse(txt_USalary.Text) / 3;

                if (a > b)
                {
                    MessageBox.Show("ALERT: This is to Advise you that we will not be able to extend credit to you at this time.");
                }
                else
                {
                    MessageBox.Show("CONGRATS: We are delighted to inform that your loan application has been approved.");
                }
            }
            catch
            {

            }

        }

        private void btn_Proceed_Click(object sender, RoutedEventArgs e)
        {
            Choice cho = new Choice();
            this.Visibility = Visibility.Hidden;
            cho.Show();
        }

        private void txt_Months_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_Months.Text != "")
            {
                try
                {
                    int a = Convert.ToInt32(txt_Months.Text);

                    if (a > 360)
                    {
                        MessageBox.Show("Invalid Amount of Months Entered", "Error");
                        txt_Months.Text = "";

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void txt_PriceProp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_DepositAmt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Interest_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Months_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}

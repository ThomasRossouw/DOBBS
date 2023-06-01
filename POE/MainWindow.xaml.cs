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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";



        private void clearAll()
        {
            //will clear all textboxes 
            txt_Income.Clear();
            txt_Tax.Clear();
            txt_Grocery.Clear();
            txt_Water.Clear();
            txt_Cell.Clear();
            txt_Travel.Clear();
            txt_Other.Clear();
            txt_Income.Focus(); // will place the cursor here after clearig the fields
        }

        private void Btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Services ser = new Services();
            this.Visibility = Visibility.Hidden;
            ser.Show();
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            //Code Below allows for Salary to be displayed in the Bond Window
            SetValueForText1 = txt_Income.Text;

            //For Vehicle Purchase
            //Expenses
            SetValueForText2 = txt_Grocery.Text;
            SetValueForText3 = txt_Water.Text;
            SetValueForText4 = txt_Cell.Text;
            SetValueForText5 = txt_Travel.Text;
            SetValueForText6 = txt_Other.Text;


            tb_Expense.Text = "                 " + "------Details of Client------" + 
                "\n --Gross Salary: R" + txt_Income.Text
               + "\n --Tax Deductions: R" + txt_Tax.Text
               + "\n --Groceries: R" + txt_Grocery.Text
               + "\n --Lights and Water: R" + txt_Water.Text
               + "\n --Cellphone Bill: R" + txt_Cell.Text
               + "\n --Travel Cost: R" + txt_Travel.Text
               + "\n --Others R" + txt_Other.Text;


            //can add another button as one button will confuse the output
            //try catch below can be used to add/subtract/*/divide between txt boxes

            try
            {
                tb_DeduTax.Text = "                " + "------Salary Minus Tax------" + "\n" + "R" + (float.Parse(txt_Income.Text) - float.Parse(txt_Tax.Text)).ToString();
            }
            catch
            {
            }
            // MessageBox.Show("Refer to details below"+"\nSalary:"+txtsalary.Text+"\nTax Deductions:"+txttax.Text);

            try
            {

                tb_Dedu1.Text = "             " + "------Salary After Deductions------" + "\n" + "R" + (float.Parse(txt_Income.Text) - float.Parse(txt_Tax.Text) - float.Parse(txt_Grocery.Text) - float.Parse(txt_Water.Text) - float.Parse(txt_Cell.Text) - float.Parse(txt_Water.Text) - float.Parse(txt_Other.Text)).ToString();
            }
            catch
            {

        }
    }

        private void txt_Income_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Tax_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Grocery_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Water_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Cell_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Travel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txt_Other_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        } 


    }
}

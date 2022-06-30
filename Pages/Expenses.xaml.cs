using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;

namespace BudgetPlannerV3.Pages
{
    /// <summary>
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Page
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //saves input into variables
            double grossMonthlyIncome = Convert.ToDouble(mntlyInc.Text);
            double monthlyTax = Convert.ToDouble(mnthyTax.Text);
            double groceriesCost = Convert.ToDouble(groceries.Text);
            double waterAndLightsCost = Convert.ToDouble(waterlights.Text);
            double travelCost = Convert.ToDouble(travel.Text);
            double phoneCost = Convert.ToDouble(phone.Text);
            double otherCost = Convert.ToDouble(otherCosts.Text);

            //creates and writes values to text file
            StreamWriter sw = new StreamWriter("Values.txt");
            sw.WriteLine(grossMonthlyIncome);
            sw.WriteLine(monthlyTax);
            sw.WriteLine(groceriesCost);
            sw.WriteLine(waterAndLightsCost);
            sw.WriteLine(travelCost);
            sw.WriteLine(phoneCost);
            sw.WriteLine(otherCost);
            //Close the file
            sw.Close();

            MessageBox.Show("Values have been entered" +
                "\nPlease choose in the menu whether you are renting or buying a home" +
                "\nOnce chosen this option cannot be changed!");
        }
    }
}

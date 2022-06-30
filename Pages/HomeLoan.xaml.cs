using System;
using System.Collections.Generic;
using System.IO;
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

namespace BudgetPlannerV3.Pages
{
    /// <summary>
    /// Interaction logic for HomeLoan.xaml
    /// </summary>
    public partial class HomeLoan : Page
    {
        public HomeLoan()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //save values to variables
            double prices = Convert.ToDouble(price.Text);
            double deposits = Convert.ToDouble(deposit.Text);
            double interestRates = Convert.ToDouble(interestRate.Text);
            double repayMonths = Convert.ToDouble(months.Text);

            //Add values to text file
            StreamWriter sw = File.AppendText("Values.txt");
            sw.WriteLine(prices);
            sw.WriteLine(deposits);
            sw.WriteLine(interestRates);
            sw.WriteLine(repayMonths);
            //Close the file
            sw.Close();

            MessageBox.Show("Values have been entered" +
                "\nIf you are buying a car please select the car icon" +
                "\nIf not select the savings icon");
        }
    }
}

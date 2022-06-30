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
    /// Interaction logic for Car.xaml
    /// </summary>
    public partial class Car : Page
    {
        public Car()
        {
            InitializeComponent();
   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //save inputs to variables
            string makeAndModel = Make.Text;
            double purchasePrice = Convert.ToDouble(price.Text); ;
            double carInterestRate = Convert.ToDouble(interestRate.Text);
            double carInsurancePremium = Convert.ToDouble(InsurancePrem.Text);
            double carDeposit = Convert.ToDouble(Deposit.Text);

            //Add values to text file
            StreamWriter sw = File.AppendText("Values.txt");
            sw.WriteLine(makeAndModel);
            sw.WriteLine(purchasePrice);
            sw.WriteLine(carInterestRate);
            sw.WriteLine(carInsurancePremium);
            sw.WriteLine(carDeposit);
            //Close the file
            sw.Close();

            MessageBox.Show("Values have been saved" +
                "\nIf you are making a savings plan, select the Savings icon" +
                "\nIf not select the Results icon");
        }
    }
}

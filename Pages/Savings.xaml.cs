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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Page
    {
        public Savings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //save inputs to variables
            double savingAmount = Convert.ToDouble(AmountToSave.Text);
            double savingDate = Convert.ToDouble(DateToSaveTill.Text);
            string reasonForSaving = Reason.Text;
            double savingInterestRate = Convert.ToDouble(interestRate.Text);

            //Add to text file
            StreamWriter sw = File.AppendText("Values.txt");
            sw.WriteLine(savingAmount);
            sw.WriteLine(savingDate);
            sw.WriteLine(reasonForSaving);
            sw.WriteLine(savingInterestRate);
            //Close the file
            sw.Close();

            MessageBox.Show("Values have been entered");
        }
    }
}

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
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Page
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //save inputs to variables
            double rentAmount = Convert.ToDouble(rent.Text);

            //Add to text file
            StreamWriter sw = File.AppendText("Values.txt");
            sw.WriteLine(rentAmount);
            //Close the file
            sw.Close();

            MessageBox.Show("Values have been entered" +
                "\nIf you are buying a car please select the car icon" +
                "\nIf not select the savings icon");
        }
    }
}

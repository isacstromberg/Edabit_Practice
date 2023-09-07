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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ArrayOfMultibles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double[] GetMultibles(double number, double length)
        {


            double counter = number;
            double LCounter = length;
            double MCounter = number;
            double Multiply = counter * MCounter;
            double[] Numbers = { };
            List<double> NumberList = new List<double>(Numbers.ToList());

            for (int i = 0; i < LCounter; i++)
            {
                NumberList.Add(counter);
                counter += MCounter;
             
                Numbers = NumberList.ToArray();
            }

            return Numbers;
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string ShowArray = "";
            string GetSpace = "";
            foreach (double item in GetMultibles(7, 5))
            {
                
                ShowArray += item;
                ShowArray += " ";
            }
            MessageBox.Show($"{ShowArray}");
        }
    }
}
/*Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.

Examples
ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35] */
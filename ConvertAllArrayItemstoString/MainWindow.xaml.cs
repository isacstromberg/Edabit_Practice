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

namespace ConvertAllArrayItemstoString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string[] MakeIntString(object[] array)
        {
            foreach (int item in array)
            {
                item.ToString();
                //lägg till i string array och konvertera
            }

            foreach (string item in array)
            {
                // lägg till i string array
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
//Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.
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

namespace ReverseAndNot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Reverse(int numbers)
        {
            string numbersToString = numbers.ToString();

            char[] charArray = numbersToString.ToCharArray();
            Array.Reverse(charArray);
            string reverseNumbers = new string(charArray);
            string returnReverse = reverseNumbers += numbersToString;

            return returnReverse;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Reverse(123456));
        }
    }
}

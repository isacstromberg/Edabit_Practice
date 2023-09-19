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

namespace ATM_Pin_Code
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

        public bool CheckIfATMCodeIsValid(string pincode)
        {
            string numbers = "1234567890";
            char[] pinToCharArray = pincode.ToCharArray();

            if (pincode.Length == 4 || pincode.Length == 6) 
            {
                foreach (char c in pinToCharArray)
                {

                    int integerValue;
                    if (int.TryParse(c.ToString(), out integerValue))
                    {
                       MessageBox.Show("Convertion successfull" + integerValue);
                    }
                    else
                    {
                        MessageBox.Show("Convertion failed, this char is not an int");
                        return false;
                    }

                    return true;

                }
            }

            return false;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckIfATMCodeIsValid("");
        }
    }
}

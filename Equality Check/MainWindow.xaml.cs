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

namespace Equality_Check
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

        public bool CheckIfEqual(object input, object inputB)
        {
            // Metod som kontrollerar om string / int / double har samma värde och retunerar true ifall det stämmer.
         
            if (input.Equals(inputB))
            {
                return true;
            }
         
            else
            {
                return false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CheckIfEqual(1, 1).ToString());
        }
    }
}
/*Both the value and type of the parameters need to be equal. The possible types of the given parameters are:

Numbers
Strings
Booleans*/
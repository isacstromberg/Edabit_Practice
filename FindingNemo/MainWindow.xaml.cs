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

namespace FindingNemo
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

        public string FindNemo(string sentence)
        {
            int counter = 0;
            string[] searchForNemo = sentence.Split();

            foreach (string item in searchForNemo)
            {
                counter++;
                if (item == "Nemo") 
                {
                    return $"I found Nemo at {counter.ToString()}!";
                }
            }

            return "I can't find Nemo :(";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(FindNemo("I found Nemo"));
        }
    }
}

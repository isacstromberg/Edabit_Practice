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

namespace H4ck3rSp34k
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string HackSpeech(string input)
        {
            string output = "";
            bool LeetSpeakChecker = false;
            // E = 3 A = 4 O = 0
            foreach (char c in input)
            {
                LeetSpeakChecker = false;


                if (c == 'A')
                {
                    LeetSpeakChecker = true;
                    output += '4';
                }

                if (c == 'a')
                {
                    LeetSpeakChecker = true;
                    output += '4';
                }
                if (c == 'E')
                {
                    LeetSpeakChecker = true;
                    output += '3';
                }
                if (c == 'e')
                {
                    LeetSpeakChecker = true;
                    output += '3';
                }
                if (c == 'O')
                {
                    LeetSpeakChecker = true;
                    output += '0';
                }
                if (c == 'o')
                {
                    LeetSpeakChecker = true;
                    output += '0';
                }
                else if (LeetSpeakChecker == false)
                {
                    output += c;
                }
              
            }

            return output;
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(HackSpeech("javascript is cool"));
        }
    }
}

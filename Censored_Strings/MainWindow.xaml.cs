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
using static System.Net.Mime.MediaTypeNames;

namespace Censored_Strings
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

        public string UncensorVowels(string text, string vowels)
        {
           
            char[] vowelsArray = vowels.ToCharArray();
            char[] charArray = text.ToCharArray();
            string uncensoredText = "";
            int counter = 0;

          

            foreach (char c in charArray)
            {
                if (c == '*')
                {
                    uncensoredText += vowelsArray[counter];
                    counter++;
                }
                else if (c != '*')
                {
                    uncensoredText += c;
                }
            }




          

            return uncensoredText;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show(UncensorVowels("n* t*st*r v* *xtr* m*ck*t", "ueaieaye"));
        }
    }
}

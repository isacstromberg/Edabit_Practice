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

        /*
         uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo") ➞ "Where did my vowels go?"

uncensor("abcd", "") ➞ "abcd"

uncensor("*PP*RC*S*", "UEAE") ➞ "UPPERCASE"
         */

        public string UncensorVowels(string text, string vowels)
        {
           
            char[] vowelsArray = vowels.ToCharArray();
            char[] charArray = text.ToCharArray();
            bool countainsCensoredLetters = false;
            string uncensoredText = "";

            foreach (char i in charArray)
            {
                if (i == '*')
                {
                    countainsCensoredLetters = true;
                }

              
            }

            if (countainsCensoredLetters == false)
            {
                return text;
            }

            foreach (char c in vowelsArray)
            {

              
                    foreach (char ch in charArray)
                    {
                        if (ch == '*')
                        {
                            uncensoredText += c;
                            break;
                        }
                        else if (ch != '*')
                        {
                            uncensoredText += ch;
                            break;
                        }

                    }
                

            }

            return uncensoredText;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show(UncensorVowels("*bcd", "a"));
        }
    }
}

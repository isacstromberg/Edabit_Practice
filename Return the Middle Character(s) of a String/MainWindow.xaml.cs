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

namespace Return_the_Middle_Character_s__of_a_String
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string CollectMiddle(string input)
        {
    
            int TheLetter = input.Length / 2 + 1;
            string MidLetters = "";
            string GetLetterEven = input.Substring(input.Length / 2 - 1, 2);
            string GetLetterOdd = input.Substring(input.Length / 2, 1);

            if (input.Length %2 == 0)
            {
                MidLetters += GetLetterEven;
    
                return MidLetters;
            }
            else
            {
                MidLetters += GetLetterOdd;
                return MidLetters;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CollectMiddle("ojämn"));
        }
    }
}


/* Create a function that takes a string and returns the middle character(s). 
 * If the word's length is odd, return the middle character. If the word's length is even, return the middle two characters.*/
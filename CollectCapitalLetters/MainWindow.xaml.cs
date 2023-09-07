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

namespace CollectCapitalLetters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string[] GetArray(string input)
        {
            // en metod som retunerar string[] som  innehåller önskade bokstäver ur en string (INPUT).
            // Denna metod retunerar specifikt en array av string input's stora bokstäver.
            string[] VowelArray = { };
            string Vowels = "ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ";
            string LetterChecker = "";
            List<string> lista = new List<string>(VowelArray.ToList());
            foreach (char item in input)
            {
                LetterChecker = item.ToString();

                if (Vowels.Contains(LetterChecker))
                {
                    lista.Add(LetterChecker);
                    VowelArray = lista.ToArray();
                }
            }
          
            return VowelArray;
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetArray("Apa Som Pluggar");
        }
    }
}

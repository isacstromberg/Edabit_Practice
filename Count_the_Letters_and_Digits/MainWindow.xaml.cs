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

namespace Count_the_Letters_and_Digits
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
        
        

      

        public string[] CalculateAmountOfNumbersAndLetters(string[] inputArray)
        {
            int amountOfNumbers = 0, amountOfLetters = 0;

            string numbers = "1234567890",
            letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuWwVvXxYyZzÅåÄäÖö";
         

            foreach (string item in inputArray)
            {
                foreach (char c in item)
                {


                    foreach (char number in numbers)
                    {
                        if (c == number)
                        {
                            amountOfNumbers++;
                        }

                        

                    }

                    foreach (char letter in letters)
                    {
                        if (c == letter)
                        {
                            amountOfLetters++;
                        }
                    }
                }
            }

          string amountOfNumbersToString = amountOfNumbers.ToString(),
                 amountOfLettersToString = amountOfLetters.ToString();

          string[] calculatedAmountOfLettersAndNumbers = new string[] { amountOfNumbersToString, amountOfLettersToString};

            return calculatedAmountOfLettersAndNumbers;


        }

        public void showCalculatedAmountOfLettersAndNumbers(string[] numbersAndLetters)
        {
            string amountOfNumbers = numbersAndLetters[0],
                   amountOfLetters = numbersAndLetters[1];

            MessageBox.Show($"Antalet siffror {amountOfNumbers} Antalet bokstäver {amountOfLetters}");
        }

        private void initializeTestBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] testData = new string[] {"ABC123"};
            showCalculatedAmountOfLettersAndNumbers(CalculateAmountOfNumbersAndLetters(testData));
        }
    }


}

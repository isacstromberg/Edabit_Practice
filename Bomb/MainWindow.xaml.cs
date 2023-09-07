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

namespace Bomb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string Bomb(string input)
        {
            string[] bombchecker = input.Split();

            foreach (string item in bombchecker)
            {
                string BombGuard = item;

                if (BombGuard == "bomb")
                {
                    return "Ducka det finns en bomb!!";
                    break;
                }
            }


            return "Det finns ingen bomb";
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Bomb("Det finns en bomb"));
        }
    }
}
//Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".




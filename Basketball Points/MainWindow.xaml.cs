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

namespace Basketball_Points
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int BallPoints(int TwoPoint, int ThreePoint)
        {
            int TwoPointValue = TwoPoint*2;
            int ThreePointValue = ThreePoint*3;
            int TotalScore = TwoPointValue + ThreePointValue;
            return TotalScore;
        }




        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{BallPoints(1, 2)}");
        }
    }
}



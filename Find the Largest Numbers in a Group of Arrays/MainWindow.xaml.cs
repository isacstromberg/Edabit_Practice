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

namespace Find_the_Largest_Numbers_in_a_Group_of_Arrays
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


        public int[] GetBiggestIntegers(int[] arr, int[] arr2, int[] arr3)
        {
   
            int[] CleanIntArray = { };
            int[] CleanIntArray2 = { };
            int[] CleanIntArray3 = { };
            int[] BiggestIntegersArray = { };
            List<int> CleanIntList = new List<int>(CleanIntArray.ToList());
        


            int max = arr[0];
            foreach (int value in arr)
            {
                if (value > max)
                    max = value;
            }
            CleanIntList.Add(max);
            CleanIntArray = CleanIntList.ToArray();

            int max2 = arr2[0];
            foreach (int value in arr2)
            {
                if (value > max2)
                    max2 = value;
            }
            CleanIntList.Add(max2);
            CleanIntArray = CleanIntList.ToArray();

            int max3 = arr3[0];
            foreach (int value in arr3)
            {
                if (value > max3)
                    max3 = value;
            }
            CleanIntList.Add(max3);
            CleanIntArray = CleanIntList.ToArray();


            return CleanIntArray;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] IntArray = {1, 3, 2};
            int[] IntArray2 = {3, 6, 7};
            int[] IntArray3 = {-2, -1, -222};


            GetBiggestIntegers(IntArray, IntArray2, IntArray3);
        }
    }
}

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

namespace Prb.Debugging.Wpf
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

        int Sum(int number1, int number2)
        {
            int sum;
            sum = number1 + number2;
            return sum;
        }

        float Divide(int number1, int number2)
        {
            float quotient;
            quotient = number1 / (float)number2;
            return quotient;
        }

        string ShowCalculations(int number1, int number2)
        {
            string results;

            results = $"{number1} + {number2} = {Sum(number1, number2)}\n";
            results += $"{number1} / {number2} = {Divide(number1, number2).ToString("0.00")}\n";
            results += "----------------------";
            return results;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int number1, number2;
            string calculations;

            number1 = int.Parse(txtNumber1.Text);
            number2 = int.Parse(txtNumber2.Text);

            calculations = ShowCalculations(number1, number2);
            tbkResult.Text = calculations;
        }


    }
}

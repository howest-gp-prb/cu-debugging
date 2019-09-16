using System.Windows;

namespace Debugging.Wpf
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

        int TelOp(int getal1, int getal2)
        {
            int som;

            som = getal1 + getal2;

            return som;
        }

        float Deel(int getal1, int getal2)
        {
            float quotient;
            quotient = getal1 / (float)getal2;
            return quotient;
        }

        string ToonBewerkingen(int getal1, int getal2)
        {
            string resultaten;

            resultaten = $"{getal1} + {getal2} = {TelOp(getal1, getal2)}\n";
            resultaten += $"{getal1} / {getal2} = {Deel(getal1, getal2).ToString("0.00")}\n";
            resultaten += "----------------------";
            return resultaten;
        }

        private void BtnBewerkingen_Click(object sender, RoutedEventArgs e)
        {
            int getal1, getal2;
            string bewerkingen;

            getal1 = int.Parse(txtGetal1.Text);
            getal2 = int.Parse(txtGetal2.Text);

            bewerkingen = ToonBewerkingen(getal1, getal2);
            tbkResult.Text = bewerkingen;
        }


    }
}

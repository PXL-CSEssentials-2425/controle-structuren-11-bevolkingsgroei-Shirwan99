using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bevolkingsgroei
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

        private void colculateButton_Click(object sender, RoutedEventArgs e)
        {
            double population = double.Parse(bevolkingTextBox.Text);
            double doublePopulation = 2.0 * population;
            int numberOfYers = 0;

            double growPercentage = double.Parse(percentageTextBox.Text);
            double growFactor = (1.0 + (growPercentage / 100.0));

            do
            {
                population *= growFactor;
                numberOfYers++;
            }
            while (population < doublePopulation);
            resultTextBox.Text = $"Verdubbeling bevolking in {landTextBox.Text} na {numberOfYers}jaar \r\n\r\n" +
                $"Nieuw bevolkingsaantal op dat moment: {population:F3}";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            landTextBox.Clear();
            bevolkingTextBox.Clear();
            percentageTextBox.Clear();
            resultTextBox.Clear();

            landTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
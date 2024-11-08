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

namespace Homework4_Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = 0;
            double height = 0;
            double BMI;
            int range;

            weight = double.Parse(weightTxtBox.Text);
            height = double.Parse(heightTxtBox.Text);

            BMI = (weight * 720) / (Math.Pow(height,2));
            BMI = Math.Round(BMI, 2);

            resultTxtBox.Text = BMI.ToString();

            if (BMI > 26)
            {
                BMICanvas.Background = Brushes.Yellow;   
            }
            else if (BMI <= 26 && BMI >= 15)
            {
                BMICanvas.Background = Brushes.Green;
            }
            else if(BMI < 15)
            {
                BMICanvas.Background = Brushes.Blue;
            }


        }
    }
}
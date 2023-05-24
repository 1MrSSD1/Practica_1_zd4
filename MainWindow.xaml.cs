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

namespace WpfApp75
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double x = double.Parse(txtX.Text);
            double c = double.Parse(txtC.Text);
            double w = double.Parse(txtW.Text);

            double y = x / (5 * Math.Sqrt(a * x) + Math.Sqrt(Math.Abs(a + x)) / 3) + 0.25 * Math.Cos(2 * a * x) + c + 24.8 / (x + w * Math.Sqrt(x));

            txtOtv.Content = $"Y = {y}";
        }
    }
}

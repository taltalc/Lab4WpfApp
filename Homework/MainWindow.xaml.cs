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

namespace Homework
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateHrivnia = Convert.ToDouble(rate2.Text);
            double sumHrivnia = Convert.ToDouble(sum2.Text);
            double resHrivnia = rateHrivnia * sumHrivnia;
            resSum2.Text = resHrivnia.ToString();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateAmd = Convert.ToDouble(rate3.Text);
            double sumAmd = Convert.ToDouble(sum3.Text);
            double resAmd = rateAmd * sumAmd;
            resSum3.Text = resAmd.ToString();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(rate4.Text);

            double resInches = rateInches * 0.0254;
            inches.Text = resInches.ToString();
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double rateFeet = Convert.ToDouble(rate5.Text);

            double resFeet = rateFeet * 0.3048;
            feet.Text = resFeet.ToString();
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double rateMiles = Convert.ToDouble(rate6.Text);

            double resMiles = rateMiles * 1609.34;
            miles.Text = resMiles.ToString();
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double rateVersts = Convert.ToDouble(rate7.Text);

            double resVersts = rateVersts * 1066.8;
            versts.Text = resVersts.ToString();
        }
    }
}
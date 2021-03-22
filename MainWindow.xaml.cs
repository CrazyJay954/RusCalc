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

namespace Sralculator2000
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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = (double.Parse(tb1.Text) + (double.Parse(tb2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = (double.Parse(tb1.Text) - (double.Parse(tb2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = (double.Parse(tb1.Text) * (double.Parse(tb2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = (double.Parse(tb1.Text) / (double.Parse(tb2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = Math.Sin(double.Parse(tb1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = Math.Cos(double.Parse(tb1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = (double.Parse(tb1.Text) / 100);
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = Math.Pow(double.Parse(tb1.Text), 2);
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = Math.Pow(double.Parse(tb1.Text), (double.Parse(tb2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = Math.Log(double.Parse(tb1.Text), (double.Parse(tb2.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l3.Content = Math.Sqrt(double.Parse(tb1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("ААААААААА. Это ООООООЧЕНЬ БООООООООООООООООООООООООООООООООЛЬНО!!!!!!!");
            }
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            l3.Content = "0";
        }
    }
}

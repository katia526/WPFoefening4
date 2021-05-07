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

namespace WPFoefening4
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

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            var tot = Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text);
            totaal.Text = tot.ToString();
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            var tot = Convert.ToInt32(txt1.Text) - Convert.ToInt32(txt2.Text);
            totaal.Text = tot.ToString();
        }

        private void Maal_Click(object sender, RoutedEventArgs e)
        {
            var tot = Convert.ToInt32(txt1.Text) * Convert.ToInt32(txt2.Text);
            totaal.Text = tot.ToString();
        }

        private void Deel_Click(object sender, RoutedEventArgs e)
        {
            var tot = Convert.ToInt32(txt1.Text) / Convert.ToInt32(txt2.Text);
            totaal.Text = tot.ToString();
        }
    }
}

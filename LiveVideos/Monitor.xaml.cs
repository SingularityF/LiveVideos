using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace LiveVideos
{
    /// <summary>
    /// Interaction logic for Monitor.xaml
    /// </summary>
    public partial class Monitor : Window
    {
        public Monitor()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/cnn.html"));


        }

        private void NBC_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/nbc.html"));
        }

        private void CNN_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/cnn.html"));

        }

        private void FOX_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/fox.html"));

        }

        private void SKY_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/sky.html"));

        }

        private void Bloomberg_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/bloomberg.html"));

        }

        private void Russia_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/russiatoday.html"));

        }

        private void France_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(System.IO.Path.GetFullPath("res/france24.html"));

        }
    }
}

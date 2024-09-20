using Gecko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace demo45._64
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GeckoWebBrowser geckoWebBrowser;
        public MainWindow()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox64");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowsFormsHost host = new WindowsFormsHost();
            geckoWebBrowser = new GeckoWebBrowser();
            host.Child = geckoWebBrowser;
            GridWeb.Children.Add(host);
            geckoWebBrowser.Navigate("http://www.google.com");
        }
    }
}

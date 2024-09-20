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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.Integration;
using System.Windows.Forms;

namespace WpfApp64
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
            Xpcom.Initialize("Firefox");            
            // InitializeXpcom();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowsFormsHost host = new WindowsFormsHost();
            geckoWebBrowser = new GeckoWebBrowser();
            host.Child = geckoWebBrowser;
            GridWeb.Children.Add(host);
            geckoWebBrowser.Navigate("http://www.google.com");
        }

        private void InitializeXpcom()
        {
            try
            {                
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string firefoxPath = System.IO.Path.Combine(basePath, "Firefox");
                Xpcom.Initialize(firefoxPath);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Failed to initialize Xpcom: " + ex.Message);
            }
        }

    }
}

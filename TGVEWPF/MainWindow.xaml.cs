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
using System.Net.Http;
using Newtonsoft.Json;

namespace TGVEWPF
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

<<<<<<< HEAD
            private void Button_Click(object sender, RoutedEventArgs e)
            {
                  NavigationService.Navigate(Control.Home);
            }
      }
=======
        private void TGVE_TextChanged(object sender, TextChangedEventArgs e)
        {
                NavigationService.Navigate(Control.Home);
        }
    }
>>>>>>> cfb414769fa15ba96b61e11b0b2c0a6ea84a6c3e
}

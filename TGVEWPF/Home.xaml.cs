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
<<<<<<< HEAD
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TGVEWPF
{
      /// <summary>
      /// Interaction logic for Home.xaml
      /// </summary>
      public partial class Home : Page
      {
            public Home()
            {
                  InitializeComponent();
            }

            private void Booking_Click(object sender, RoutedEventArgs e)
            {
                  NavigationService.Navigate(Control.Booking);
            }

            private void Tour_Click_1(object sender, RoutedEventArgs e)
            {
                  NavigationService.Navigate(Control.Tour);
            }

            private void Event_Click(object sender, RoutedEventArgs e)
            {
                  NavigationService.Navigate(Control.Events);
            }
      }
=======
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace TGVEWPF
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        Control Control;
        public Home()
        {
            InitializeComponent();
            Control = new Control(this);
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Control.Event);
        }

        private void tours_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Control.Tours);
        }

        private void Bookings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Control.Booking);
        }
  
        private void home_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Control.Home);
        }
    }
>>>>>>> cfb414769fa15ba96b61e11b0b2c0a6ea84a6c3e
}

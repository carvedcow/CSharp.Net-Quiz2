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

namespace CSharp.Net_Quiz2
{
    /// <summary>
    /// Interaction logic for Question3.xaml
    /// </summary>
    public partial class Question3 : Window
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void cb_Tab2_Checked(object sender, RoutedEventArgs e)
        {
            ti_tab2.Visibility = Visibility.Visible;
        }

        private void cb_Tab2_Unchecked(object sender, RoutedEventArgs e)
        {
            ti_tab2.Visibility = Visibility.Hidden;
        }
    }
}

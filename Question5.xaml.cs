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
    /// Interaction logic for Question5.xaml
    /// </summary>
    public partial class Question5 : Window
    {
        int clickCounter = 0;
        public Question5()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            clickCounter++;
            btn1.Content = clickCounter;
            if (clickCounter % 2 == 0)
            {
                tvTree1.Items.Add(clickCounter);
                btn1.Background = Brushes.Blue;
            }
            else if (clickCounter % 2 == 1)
            {
                tvTree2.Items.Add(clickCounter);
                btn1.Background = Brushes.Red;
            }
        }
    }
}

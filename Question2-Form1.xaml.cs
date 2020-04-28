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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void SendForm2_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDateTime = (DateTime)selectedDT.SelectedDate;

            Question2_Form2 Form2 = new Question2_Form2();
            Form2.label1.Content = selectedDateTime.ToString("d/M/yyyy");
            Form2.Show();
        }

    }
}

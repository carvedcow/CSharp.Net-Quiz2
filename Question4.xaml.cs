using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Question4.xaml
    /// </summary>
    public partial class Question4 : Window
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        private ObservableCollection<Student> selectedStudents = new ObservableCollection<Student>();
        public Question4()
        {
            InitializeComponent();

            students.Add(new Student(1, "John"));
            students.Add(new Student(2, "Joe"));
            students.Add(new Student(3, "Jim"));
            students.Add(new Student(4, "Jan"));
            students.Add(new Student(5, "Jones"));

            lbStudents.ItemsSource = selectedStudents;
        }

        private void btnShowStudent_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent;

            foreach (Student s in students)
            {
                if (s.Id == Int32.Parse(tbStudentID.Text))
                {
                    selectedStudent = s;
                    if (selectedStudents.Contains(selectedStudent))
                    {
                        MessageBox.Show("Student is already in the list.", "Warning");
                    }
                    else
                    {
                        selectedStudents.Add(selectedStudent);
                    }
                }

            }
        }
    }


}

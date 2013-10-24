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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stdDataClasses1DataContext std = new stdDataClasses1DataContext();
            listbox1.ItemsSource = std.Students;
            cmb1.ItemsSource = std.Departments;

            cmb1.SelectedValuePath = "deptId";
            cmb1.DisplayMemberPath = "deptName";
            
        }

        private void listbox1_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listbox1.SelectedItem != null)
            {
                cmb1.SelectedValue = ((Student)listbox1.SelectedItem).deptID;
            }
        }

        private void TextBox_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
          
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void label5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fm = new Microsoft.Win32.OpenFileDialog();
            fm.ShowDialog();
            imagelbl.Text = fm.FileName;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student st = new Student();
            st.stuId = int.Parse(idtxt.Text);
            st.stuName = nametxt.Text;
            st.age = int.Parse(agetxt.Text);
            st.image = imagelbl.Text;
            st.deptID = (int)cmb1.SelectedValue;

            stdDataClasses1DataContext std = new stdDataClasses1DataContext();
            std.Students.InsertOnSubmit(st);
            std.SubmitChanges();
            MessageBox.Show("Added succesfully....!");
            listbox1.ItemsSource = std.Students;
            cmb1.ItemsSource = std.Departments;


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            stdDataClasses1DataContext std = new stdDataClasses1DataContext();
            var q1 = (from stu in std.Students
                      where stu.stuId == int.Parse(idtxt.Text)
                      select stu).SingleOrDefault();
            if (q1 != null)
            {
                q1.stuName = nametxt.Text;
                q1.age = int.Parse(agetxt.Text);
                q1.image = imagelbl.Text;
                q1.deptID = (int)cmb1.SelectedValue;
                std.SubmitChanges();
                MessageBox.Show("Update succesfully....!");
                listbox1.ItemsSource = std.Students;
                cmb1.ItemsSource = std.Departments;


            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            stdDataClasses1DataContext std = new stdDataClasses1DataContext();
            var q1 = (from stu in std.Students
                      where stu.stuId == int.Parse(idtxt.Text)
                      select stu).SingleOrDefault();
            if (q1 != null)
            {
                std.Students.DeleteOnSubmit(q1);
               
                std.SubmitChanges();
                MessageBox.Show("Delete succesfully....!");
                listbox1.ItemsSource = std.Students;
                cmb1.ItemsSource = std.Departments;


            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }
    }
}

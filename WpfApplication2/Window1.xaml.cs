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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            stdDataClasses1DataContext std = new stdDataClasses1DataContext();
            listbox1.ItemsSource = std.Students;
            cmbbox1.ItemsSource = std.Departments;

            cmbbox1.SelectedValuePath = "deptId";
            cmbbox1.DisplayMemberPath = "deptName";
        }

        private void cmbbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Department d = (Department)cmbbox1.SelectedItem;
            listbox1.ItemsSource = d.Students;
        }
    }
}

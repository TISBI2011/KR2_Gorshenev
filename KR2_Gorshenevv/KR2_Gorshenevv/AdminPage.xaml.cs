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

namespace KR2_Gorshenevv
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            DGEmployee.ItemsSource = App.DB.Employee.ToList();
        }

        private void BAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployee());
        }

        private void BDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmployee = DGEmployee.SelectedItem as Employee;
            if (selectedEmployee == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }
            App.DB.Employee.Remove(selectedEmployee);
            App.DB.SaveChanges();
            DGEmployee.ItemsSource = App.DB.Employee.ToList();
        }
    }
}

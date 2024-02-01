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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = TBLogin.Text;
            string password = TBPassword.Text;

            var loggedUser = App.DB.User.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (loggedUser == null)
            {
                MessageBox.Show("Логин или пароль неверны");
                return;
            }

            App.LoggedUser = loggedUser;

if (loggedUser.RoleId == 1)
            {
                NavigationService.Navigate(new AdminPage());
            }

if (loggedUser.RoleId == 3)
            {
                NavigationService.Navigate(new MainPage());
            }

            
               

                
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

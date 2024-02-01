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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        Task contextTask;


        public MainPage()
        {
            InitializeComponent();
            contextTask = new Task();
           // contextTask.Order = App.LoggedUser;
            DGTasks.ItemsSource = App.DB.Task.ToList();
            
        }

        private void BMyTasks_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

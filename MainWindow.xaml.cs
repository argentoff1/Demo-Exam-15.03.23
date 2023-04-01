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

namespace _15._03._2023
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            using(var db = new Entities())
            {
                User user = new User { Username = username.Text, Password = password.Password };
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        private void authorization_Click(object sender, RoutedEventArgs e)
        {
            using(var db = new Entities())
            {
                var users = db.User.Where(u => u.Username == username.Text && u.Password == password.Password);
                if (users.Count() == 1)
                {
                    Session.currentUser = users.First();
                    Hide();
                    Window1 window1 = new Window1();
                    window1.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин и/или пароль");
                }
            }
        }
    }
}

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

namespace _15._03._2023
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using(var db = new Entities())
            {
                Session.currentUser.Magazine.ToList().ForEach(m => groups.Items.Add(m.Group));
            }
        }

        private void groups_Selected(object sender, RoutedEventArgs e)
        {
            using(var db = new Entities())
            {
                specialities.Items.Clear();
                Group group = groups.SelectedItem as Group;
                db.Magazine.Where(m => m.GroupId == group.id && m.TeacherId == Session.currentUser.id).ToList().ForEach(m => specialities.Items.Add(m.Discipline));
            }
        }
    }
}

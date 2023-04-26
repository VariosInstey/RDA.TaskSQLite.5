using RDA.TaskSQLite._5.Model;
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

namespace RDA.TaskSQLite._5.View
{
    /// <summary>
    /// Логика взаимодействия для InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public List<User> DatabaseUsers { get; private set; }
        public InfoWindow()
        {
            InitializeComponent();
            Read();
        }

        public void Create()
        {
            try
            {
                    var Login = TbLogin.Text;
                    var Password = PbPassword.Password;
                    using (DataContext db = new DataContext())

                        if (string.IsNullOrEmpty(TbLogin.Text) ||
                    string.IsNullOrEmpty(PbPassword.Password))
                    


                {
                    MessageBox.Show($"Не все строки заполнены!");
                }
                else
                {
                    db.Users.Add(new User()
                    {
                        Login = TbLogin.Text,
                        Password = PbPassword.Password
                    });
                    db.SaveChanges();
                    MessageBox.Show($"User создан!");
                    TbLogin.Text = string.Empty;
                    PbPassword.Password = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error 3");
            }
        }
        public void Read()
        {
            using (DataContext db = new DataContext())
            {
                DatabaseUsers = db.Users.ToList();
                LVInfo.ItemsSource = DatabaseUsers;
            }
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            LVInfo.Items.Clear();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

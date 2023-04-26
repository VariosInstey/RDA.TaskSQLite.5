using RDA.TaskSQLite._5.Model;
using RDA.TaskSQLite._5.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace RDA.TaskSQLite._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Login = TbLogin.Text;
                var Password = PbPassword.Password;
                using (DataContext db = new DataContext())
                {
                    bool userFound = db.Users.Any(u => u.Login == Login && u.Password == Password);
                    if (userFound)
                    {
                        MessageBox.Show("Успешная авторизация!",
                            "Системное сообщение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                        new InfoWindow().Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка данных",
                            "Системное сообщение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }

        }
    }
}

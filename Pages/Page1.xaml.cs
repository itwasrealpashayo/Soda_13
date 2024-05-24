using Soda_13.Database;
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

namespace Soda_13.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            User objUser = Soda13Entities.GetContext().User.FirstOrDefault(x => x.UserLogin == TxbLogin.Text && x.UserPassword == PsbPassword.Password);
            
            if(objUser != null)
            {


                switch(objUser.RoleID)
                {
                    case 1:
                        MessageBox.Show($"Здраствуйте {objUser.UserSurname} {objUser.UserName}!",
                                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Utils.Manager.MainFrame.Navigate(new Page2());
                        break;
                    case 2:
                        MessageBox.Show($"Здраствуйте {objUser.UserSurname} {objUser.UserName}!",
                                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Utils.Manager.MainFrame.Navigate(new Page2());
                        break;
                    case 3:
                        MessageBox.Show($"Здраствуйте {objUser.UserSurname} {objUser.UserName}!",
                                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Utils.Manager.MainFrame.Navigate(new Page2());
                        break;

                }
            }
            else 
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

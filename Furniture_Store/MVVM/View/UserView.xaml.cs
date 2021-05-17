using System.Windows;
using System.Windows.Controls;
using Furniture_Store.Classes;

namespace Furniture_Store.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();
            UserControlSingleton instance = UserControlSingleton.GetInstance();
            if (instance.IsLogged)
            {
                this.ChangeForm(true, instance.Name, instance.Role);
            }
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            UserControlSingleton instance = UserControlSingleton.GetInstance();
            var login = (TextBox)this.FindName("Login");
            var password = (PasswordBox)this.FindName("Password");

            if (login?.Text == "admin" && password?.Password == "admin")
            {
                this.ChangeForm(true, "admin", "admin");

                instance.IsLogged = true;
                instance.UserID = 1;
                instance.Name = "admin";
                instance.Role = "admin";

                var errorMessage = (Label)this.FindName("ErrorMessage");
                if (errorMessage.Visibility == Visibility.Visible)
                {
                    errorMessage.Visibility = Visibility.Hidden;
                }

                this.AnableControlsOnMainWindow(true);
            }
            else
            {
                var errorMessage = (Label)this.FindName("ErrorMessage");
                errorMessage.Visibility = Visibility.Visible;
            }
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            UserControlSingleton instance = UserControlSingleton.GetInstance();
            instance.IsLogged = false;
            instance.UserID = 0;

            this.ChangeForm(false, null, null);
            this.AnableControlsOnMainWindow(false);
        }

        private void ChangeForm(bool loggedIn, string name, string role)
        {
            if (loggedIn)
            {
                var loginBox = (GroupBox)this.FindName("LoginBox");
                loginBox.Visibility = Visibility.Hidden;

                var userBox = (GroupBox)this.FindName("UserBox");
                userBox.Visibility = Visibility.Visible;
                var userName = (TextBlock)this.FindName("UserName");
                userName.Text = "admin";
                var userRole = (TextBlock)this.FindName("Role");
                userRole.Text = "admin";
            }
            else
            {
                var userBox = (GroupBox)this.FindName("UserBox");
                userBox.Visibility = Visibility.Hidden;

                var loginBox = (GroupBox)this.FindName("LoginBox");
                loginBox.Visibility = Visibility.Visible;
            }
        }

        private void AnableControlsOnMainWindow(bool enable)
        {
            var ordersButton = (RadioButton)Application.Current.MainWindow.FindName("OrdersButton");
            ordersButton.IsEnabled = enable;
            var homesButton = (RadioButton)Application.Current.MainWindow.FindName("HomeButton");
            homesButton.IsEnabled = enable;
            var busketButton = (RadioButton)Application.Current.MainWindow.FindName("BasketButton");
            busketButton.IsEnabled = enable;
        }
    }
}

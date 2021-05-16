using System;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;
using System.Management.Instrumentation;

namespace Capstone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private SqlConnection _conn = new SqlConnection();
        private SqlCommand _command = new SqlCommand();
        private SqlDataReader _dr;
        public MainWindow()
        {
            InitializeComponent();
            _conn.ConnectionString =
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegisterText_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {                
                RegisterWindow newWind = new RegisterWindow();
                this.Close();
                newWind.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(_conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }
            List<bool> check = VerifyUser(UserName.Text, UserPassword.Password);
            if (check[0] == true && check[1] == false)
            {
                MessageBox.Show("Logged In Successfully", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
                Second newWind = new Second(UserName.Text);
                this.Close();
                newWind.ShowDialog();
            }
            else if (check[0] == true && check[1] == true)
            {
                MessageBox.Show("Logged In Successfully", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
                AdminWindow newWind = new AdminWindow(UserName.Text);
                this.Close();
                newWind.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private List<bool> VerifyUser(string username, string password)
        {
            _conn.Open();
            _command.Connection = _conn;
            _command.CommandText = "select Status, Role from Users where Username='" + username + "' and password='" +
                                   password + "'";
            _dr = _command.ExecuteReader();
            if (_dr.Read())
            {
                if (Convert.ToBoolean(_dr["Status"]) == true && Convert.ToString(_dr["Role"]) == "Admin")
                {
                    return new List<bool>(2){true, true};
                }
                else if (Convert.ToBoolean(_dr["Status"]) == true && Convert.ToString(_dr["Role"]) == "User")
                {
                    return new List<bool>(2){true, false};
                }
                else
                {
                    MessageBox.Show("Your Account Has Been Suspended or Doesn't Exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return new List<bool>(2){false, false};
                }
            }
            else
            {
                return new List<bool>(2){false, false};
            }
        }
    }
}
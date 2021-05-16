using System;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace Capstone
{
    public partial class RegisterWindow : Window
    {
        private SqlConnection _conn = new SqlConnection();
        private SqlCommand _command = new SqlCommand();
        private SqlDataReader _dr;
        public RegisterWindow()
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWind = new MainWindow();
            this.Close();
            newWind.ShowDialog();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if(_conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }

            if (UserName.Text != "" && Email.Text != "" && UserPassword.Password != "" &&
                ConfirmUserPassword.Password != "" && new EmailAddressAttribute().IsValid(Email.Text))
            {
                if (VerifyNewUser(UserName.Text, UserPassword.Password, ConfirmUserPassword.Password))
                {
                    SendEMail(Email.Text);
                    MessageBox.Show("Registered Successfully", "Registration", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    MainWindow newWind = new MainWindow();
                    this.Close();
                    newWind.ShowDialog();
                }
            }
            else if (!new EmailAddressAttribute().IsValid(Email.Text))
            {
                MessageBox.Show("Incorrect E-Mail Input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (UserName.Text == "" && Email.Text != "" && UserPassword.Password != "" &&
                      ConfirmUserPassword.Password != "")
            {
                MessageBox.Show("Username Must Be Filled", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (UserName.Text != "" && Email.Text == "" && UserPassword.Password != "" &&
                     ConfirmUserPassword.Password != "")
            {
                MessageBox.Show("Email Must Be Filled", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (UserName.Text != "" && Email.Text != "" && UserPassword.Password == "" &&
                     ConfirmUserPassword.Password != "")
            {
                MessageBox.Show("Password Must Be Filled", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (UserName.Text != "" && Email.Text != "" && UserPassword.Password != "" &&
                     ConfirmUserPassword.Password == "")
            {
                MessageBox.Show("Confirm Password Must Be Filled", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SendEMail(string email)
        {
            MailAddress from = new MailAddress("maxim.akulevich@gmail.com");
            MailAddress to = new MailAddress(email);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Registration";
            message.Body = "<h2>You Have Been Successfully Registered on Noted!</h2>";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("maxim.akulevich@gmail.com", "jvbmpcuzfrsqpzwk");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            try
            { 
                smtp.Send(message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private bool VerifyNewUser(string username, string password, string confirmPassword)
        {
            _conn.Open();
            _command.Connection = _conn;
            _command.CommandText = "select Username from Users where Username='" + username + "'";
            _dr = _command.ExecuteReader();
            if (!_dr.Read())
            {
                if (password == confirmPassword)
                {
                    _conn.Close();
                    _conn.Open();
                    _command.Connection = _conn;
                    _command.CommandText = "insert into Users(Username, Password, Status, Role) values('" + UserName.Text +
                                           "','"+ UserPassword.Password +"', 1, 'User')";
                    _command.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    MessageBox.Show("Passwords Don't Match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
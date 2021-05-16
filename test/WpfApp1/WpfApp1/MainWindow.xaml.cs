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

namespace WpfApp1
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

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBox_Login.Text.Trim(); //trim удаляет лишние пробелы до и после строки
            string pass1 = PassBox1.Password.Trim();
            string pass2 = PassBox2.Password.Trim();
            string email = textBox_Email.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBox_Login.ToolTip = "Длина логина меньше 5 символов";
                textBox_Login.Background = Brushes.DarkRed;
            }
            else if (pass1.Length < 5)
            {
                PassBox1.ToolTip = "Длина пароля меньше 5 символов";
                PassBox1.Background = Brushes.DarkRed;
            }
            else if (pass1 != pass2)
            {
                PassBox2.ToolTip = "Пароли не свопадают";
                PassBox2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBox_Email.ToolTip = "Некорректный email адрес";
                textBox_Email.Background = Brushes.DarkRed;
            }
            else
            {
                textBox_Login.ToolTip = null;
                textBox_Login.Background = Brushes.Transparent;
                PassBox1.ToolTip = null;
                PassBox1.Background = Brushes.Transparent;
                PassBox2.ToolTip = null;
                PassBox2.Background = Brushes.Transparent;
                textBox_Email.ToolTip = null;
                textBox_Email.Background = Brushes.Transparent;

                MessageBox.Show("Аккаунт зарегестрирован!");
            }
        }
    }
}

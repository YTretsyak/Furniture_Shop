using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Configuration;


namespace Capstone
{
    public partial class Second : Window
    {
        private SqlConnection _conn = new SqlConnection();
        private SqlCommand _command = new SqlCommand();
        public Second()
        {
            InitializeComponent();
            _conn.ConnectionString =
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public Second(string username)
        {
            InitializeComponent();
            Username.Text = username;
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

        private void btnLeave_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWind = new MainWindow();
            this.Close();
            newWind.ShowDialog();
        }
    }
}
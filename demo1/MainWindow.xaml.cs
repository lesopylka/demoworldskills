using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Data.SqlClient;
using System.Data;
using CaptchaDemo;

namespace demo1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CAPTCHA _captcha;
        static int counter = 0;


        public MainWindow()
        {
            InitializeComponent();

            _captcha = new CAPTCHA(OutTextCaptcha,InputTextCaptcha, RefreshCaptcha);
        }


        static string GetRule(string Логин, string Пароль)
        {
            string rule = null;
            if (!string.IsNullOrEmpty(Логин) && !string.IsNullOrEmpty(Пароль))
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-KPLK5BQC\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True"))
                {
                    SqlCommand Command = new SqlCommand("SELECT Должность FROM [Сотрудники] WHERE Логин = @Логин AND Пароль = @Пароль");
                    Command.Connection = connection;
                    Command.Parameters.AddWithValue("@Логин", Логин);
                    Command.Parameters.AddWithValue("@Пароль", Пароль);
                    connection.Open();
                    rule = (string)Command.ExecuteScalar();
                }
            }
            return rule;

        }


        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            counter++;

            string rule = GetRule(EmailBox.Text, PasswordBox.Password);

            if (counter == 2)
            {
                OutTextCaptcha.Visibility = Visibility.Visible;
                InputTextCaptcha.Visibility = Visibility.Visible;
                RefreshCaptcha.Visibility = Visibility.Visible;
                NextBtn.Visibility = Visibility.Visible;
                MessageBox.Show("Неправильный логи или пароль.Введите капчу и попробуйте вновь!");      
                LoginBtn.IsEnabled = false;
                    }
           
            else
            {
                if (rule == "Продавец")
                {
                    SalesMan salesMan = new SalesMan();
                    salesMan.Show();
                    this.Close();
                }
                if (rule == "Старший смены")
                {
                    Superviser superviser = new Superviser();
                    superviser.Show();
                    this.Close();

                }
                if (rule == "Администратор")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();

                }


            }
            
        }

        private void HiddenPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = passwordTxtBox.Text;
            passwordTxtBox.Visibility = Visibility.Collapsed;
            PasswordBox.Visibility = Visibility.Visible;

        }

        private async void HiddenPassword_Checked(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = PasswordBox.Password;
            PasswordBox.Visibility = Visibility.Collapsed;
            passwordTxtBox.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_captcha.IsCorrectCaptcha)
            {
                MessageBox.Show("Верно");
                LoginBtn.IsEnabled = true;

                OutTextCaptcha.Visibility = Visibility.Hidden;
                InputTextCaptcha.Visibility = Visibility.Hidden;
                RefreshCaptcha.Visibility = Visibility.Hidden;
                NextBtn.Visibility = Visibility.Hidden;
            }
        }

       

    }
}

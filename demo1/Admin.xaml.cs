﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace demo1
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {

        private const int MaxSecond = 120;
        private int Second = 0;

        public Admin()
        {
            InitializeComponent();
            Timer();
        }

        private async void Timer()
        {
            for (Second = 1; Second < MaxSecond + 1; Second++)
            {
                await Task.Delay(1000);
                if (Second < 60) tbTime.Text = "Время сеанса: " + Second + " сек.";
                else tbTime.Text = "Время сеанса: " + Second / 60 + " мин.";
                if (Second == 30)
                {
                    MessageBox.Show("До окночания сеанса осталось 30 секунд");
                }
            }
            MessageBox.Show("Ваше время сеанса вышло!");
            Exit();

        }

        private void Exit()
        {
            Application.Current.MainWindow.Close();
        }


    }


}

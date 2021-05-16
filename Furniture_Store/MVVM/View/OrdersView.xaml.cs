﻿using System;
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
using Furniture_Store.Classes;

namespace Furniture_Store.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для OrdersView.xaml
    /// </summary>
    public partial class OrdersView : UserControl
    {
        public OrdersView()
        {
            InitializeComponent();
            UserControlSingleton instance = UserControlSingleton.GetInstance();
            if (instance.IsLogged != true) 
            {
                this.IsEnabled = true;
            }
        }
    }
}

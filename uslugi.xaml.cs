﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp32
{
    /// <summary>
    /// Логика взаимодействия для uslugi.xaml
    /// </summary>
    public partial class uslugi : Window
    {
        public uslugi()
        {
            InitializeComponent();
        }
        public string s = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Page uslug = new uslugi_reg();
            frame.Navigate(uslug);
            s = ".";
        }
    }
}

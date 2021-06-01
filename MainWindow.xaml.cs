using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace WpfApp32
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.wingrid.Background = new SolidColorBrush(Colors.White);
        }

        private void AuthButton_GotFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void AuthButton_MouseEnter(object sender, MouseEventArgs e)
        {
          //  authButton.Content = "НЕ НАЖИМАТЬ!!!!!!!";
            
        }

        private void AuthButton_MouseLeave(object sender, MouseEventArgs e)
        {
            authButton.Content = "Авторизация";
            
        }

        private void AuthButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //try
            {
                MainWindow mw = new MainWindow();

                Window ath = new auth();
                ath.Show();
                
               
              
              
            }
           // catch
            {
                
             //   return;
            }
            
            
        }

       

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
            var windowClose = MessageBox.Show("хотите выйти", "окно которое бесит вас", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel) == MessageBoxResult.OK;
            if (windowClose == false)
            {
                e.Cancel = true;
            }
        }

        private void Title_MouseEnter(object sender, MouseEventArgs e)
        {
    
            
        }
        private void Title_MouseLeave(object sender, MouseEventArgs e)
        {
           
        }
        SolidColorBrush brushL = new SolidColorBrush();
        SolidColorBrush brush = new SolidColorBrush();
        ColorAnimation da = new ColorAnimation();
        ColorAnimation net = new ColorAnimation();

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            wingrid.Background = brush;
            da.From = Colors.White;
            da.To = Colors.Gray;
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            brush.BeginAnimation(SolidColorBrush.ColorProperty, da);

            authButton.Foreground = brushL;
            title.Foreground = brushL;
            USLUGI_LINK.Foreground = brushL;
            net.From = Colors.Black;
            net.To = Colors.White;
            net.Duration = new Duration(TimeSpan.FromSeconds(1));
            brushL.BeginAnimation(SolidColorBrush.ColorProperty, net);
           

        }

        private void Darkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            da.From = Colors.Gray;
            da.To = Colors.White;
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            brush.BeginAnimation(SolidColorBrush.ColorProperty, da);
            USLUGI_LINK.Foreground = brushL;
            authButton.Foreground = brushL;
            title.Foreground = brushL;
            net.From = Colors.White;
            net.To = Colors.Black;
            net.Duration = new Duration(TimeSpan.FromSeconds(1));
            brushL.BeginAnimation(SolidColorBrush.ColorProperty, net);


        }

        private void Wingrid_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }

        public void authscs()
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uslugi Uslugi = new uslugi();
            Uslugi.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }
    }
}

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
using System.Threading.Tasks;
using System.Threading;

namespace WpfApp32
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string d;
        public MainWindow()
        {
            InitializeComponent();
            this.wingrid.Background = new SolidColorBrush(Colors.White);//создаю экземпляр кисти на элемент Grid, белого цвета
            debug.Content = d;

        }

        private void AuthButton_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void AuthButton_MouseEnter(object sender, MouseEventArgs e)
        {
            authButton.Content = "НЕ НАЖИМАТЬ!!!!!!!";
        }

        private void AuthButton_MouseLeave(object sender, MouseEventArgs e)
        {
            authButton.Content = "Авторизация";
        }

        private void AuthButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();

           
            Window ath = new auth();


            ath.ShowDialog();

            if (ath.DialogResult == true)
            {
                authButton.Content = "Вы авторизованы";
                lgscs.Visibility = Visibility.Visible; //
                butt.Visibility = Visibility.Hidden; //
                mw.Show(); //
            }
            mw.Hide(); //









        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            var windowClose = MessageBox.Show("хотите выйти", "окно которое бесит вас", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel) == MessageBoxResult.OK;
            if (windowClose == false)
            {
                e.Cancel = true; // отмена закрытия окна
            }
            else
            {
                Application.Current.Shutdown(); //закрытие окон
            }
        }

        private void Title_MouseEnter(object sender, MouseEventArgs e)
        {


        }
        private void Title_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        SolidColorBrush brushL = new SolidColorBrush(); // создаем обращение к экземпляру кисти в виде переменной
        SolidColorBrush brush = new SolidColorBrush(); // создаем обращение к экземпляру кисти в виде переменной
        ColorAnimation da = new ColorAnimation(); // объявление экземпляра анимации смены цвета
        ColorAnimation net = new ColorAnimation(); // объявление экземпляра анимации смены цвета

        private void change()
        {
            d = "1";
            wingrid.Background = brush;// привязка кисти к фону элемента Grid
            da.From = Colors.White;// указываем с какого цвета начнется анимация
            da.To = Colors.Gray;// указываем на каком цвете закончится анимация
            da.Duration = new Duration(TimeSpan.FromSeconds(1));// настройка задержки анимации в 1 секунду
            brush.BeginAnimation(SolidColorBrush.ColorProperty, da);// точка старта анимации


            authButton.Foreground = brushL;// привязка кисти к цвету текста элемента кнопки авторизации
            title.Foreground = brushL;// привязка кисти к цвету текста названия программного продукта
            USLUGI_LINK.Foreground = brushL;// привязка кисти к цвету текста элемента кнопки с услугами
            lgscs.Foreground = brushL;//привязка кисти к цвету текста надписи авторизации
            darkbox.Foreground = brushL;//привязка кисти к цвету текста переключателя
            net.From = Colors.Black;// указываем с какого цвета начнется анимация
            net.To = Colors.White;//указываем на каком цвете закончится анимация
            net.Duration = new Duration(TimeSpan.FromSeconds(1));// настройка задержки анимации в 1 секунду
            brushL.BeginAnimation(SolidColorBrush.ColorProperty, net);// точка старта анимации

        }

        private void chAnge()
            {
            d = "0";
            
            da.From = Colors.Gray;//указываем с какого цвета начнется анимация
            da.To = Colors.White;//указываем на каком цвете закончится анимация
            da.Duration = new Duration(TimeSpan.FromSeconds(1));//настройка задержки анимации в 1 секунду
            brush.BeginAnimation(SolidColorBrush.ColorProperty, da);// точка старта анимации
            USLUGI_LINK.Foreground = brushL;// привязка кисти к цвету текста элемента кнопки с услугами
            authButton.Foreground = brushL;//привязка кисти к цвету текста надписи авторизации
            title.Foreground = brushL;//привязка кисти к цвету текста названия программного продукта
            net.From = Colors.White;// указываем с какого цвета начнется анимация
            net.To = Colors.Black;//указываем на каком цвете закончится анимация
            net.Duration = new Duration(TimeSpan.FromSeconds(1));//настройка задержки анимации в 1 секунду
            brushL.BeginAnimation(SolidColorBrush.ColorProperty, net);// точка старта анимации
            
        }
        private async void CheckBox_Checked( object sender, RoutedEventArgs e)
        {
            
            
            change();
            await Task.Delay(1000);
            wingrid.Background = Brushes.Gray;
         
            
            
            
        }

        private async void Darkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            
            chAnge();
          
            await Task.Delay(1000);


            
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            uslugi Uslugi = new uslugi();
            Uslugi.Show();
        }

     
    }
}

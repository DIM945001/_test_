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
        public string d= "";
        public MainWindow()
        {
            InitializeComponent();

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
          
           
            auth ath = new auth();
            

            ath.ShowDialog();

            if (ath.DialogResult == true)
            {
                d = role.Content.ToString();    
                authButton.Content = "Вы авторизованы";
                lgscs.Visibility = Visibility.Visible; //
                butt.Visibility = Visibility.Hidden; //

                
            }
            switch (ath.comboBox.Text)
            {
                case "клиент":

                    break;

                case "сотрудник":
                    listbut.Visibility = Visibility.Visible;
                    break;
                case "инспектор":
                    listbut.Visibility = Visibility.Visible;
                    break;
                case "бухгалтер":
                    listbut.Visibility = Visibility.Visible;
                    taskbut.Visibility = Visibility.Visible;
                    break;
            }










            }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            var windowClose = MessageBox.Show("хотите выйти", "окно которое бесит вас", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel) == MessageBoxResult.OK;
            if (windowClose == false)
            {
                e.Cancel = true; // отмена закрытия окна
            }
          
            
        }

        private void Title_MouseEnter(object sender, MouseEventArgs e)
        {


        }
        private void Title_MouseLeave(object sender, MouseEventArgs e)
        {

        }

      


      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            uslugi Uslugi = new uslugi();
            Uslugi.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void listbut_Click(object sender, RoutedEventArgs e)
        {
            client_list cl = new client_list();
            uslugi_reg uslugi = new uslugi_reg();
            cl.Show();
            cl.comboBox.Items.Add("P");
        }

        private void taskbut_Click(object sender, RoutedEventArgs e)
        {
            tasks tsk = new tasks();
            tsk.Show();
        }
    }
}

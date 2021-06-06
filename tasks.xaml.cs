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
using System.Windows.Shapes;

namespace WpfApp32
{
    /// <summary>
    /// Логика взаимодействия для tasks.xaml
    /// </summary>
    public partial class tasks : Window
    {
        public tasks()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Клиент 1: Договор N:314554, Вид:ДМС от несчастных случаев, Страховой Случай:Да Статус: Оплачено");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отчеты отправлены");
        }
    }
}

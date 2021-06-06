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

namespace WpfApp32
{
    /// <summary>
    /// Логика взаимодействия для uslugi_reg.xaml
    /// </summary>
    public partial class uslugi_reg : Page
    {
        public uslugi_reg()
        {
            InitializeComponent();
        }
        
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            client_list client_ = new client_list();
            uslugi usl = new uslugi();
           
            MessageBox.Show("Заявка отправлена", "Услуги");
            client_.comboBox.Items.Add("заявка от клиента");
            

        }
    }
}

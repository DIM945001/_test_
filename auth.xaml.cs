using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.SqlClient;


namespace WpfApp32
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Window
    {
        public auth()
        {
            InitializeComponent();
            DataTable dt_user = Select("SELECT * FROM [dbo].[users]"); // получаем данные из таблицы
            for (int i = 0; i < dt_user.Rows.Count; i++)
            { // перебираем данные
                MessageBox.Show(dt_user.Rows[i][0] + "|" + dt_user.Rows[i][1]); // выводим данные
            }
        }
        MainWindow mw = new MainWindow();

        // string login = "login";
        // string pass = "qwerty";

        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection("server=CAB212-2;Trusted_Connection=yes;DataBase=AUTH;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
           
            return dataTable;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

                if (textbox1.Text.Length > 0) // проверяем введён ли логин     
                {
                    if (textbox2.Password.Length > 0) // проверяем введён ли пароль         
                    {             // ищем в базе данных пользователя с такими данными         
                        DataTable dt_user = Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + textbox1.Text + "' AND [password] = '" + textbox2.Password + "'");
                        if (dt_user.Rows.Count > 0) // если такая запись существует       
                        {
                            MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался         
                        }
                        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                    }
                    else MessageBox.Show("Введите пароль"); // выводим ошибку    
                }
                else MessageBox.Show("Введите логин"); // выводим ошибку 
            }








            //        if (login == textbox1.Text)
            //        {
            //            if (pass == textbox2.Password)
            //            {
            //                MessageBox.Show("OK");
            //                DialogResult = true;
            //                mw.butt.Visibility = Visibility.Hidden;
            //                mw.lgscs.Visibility = Visibility.Visible;
            //            }
            //            else
            //            {
            //                if (textbox2.Password == "")
            //                {
            //                    MessageBox.Show("где пароль");
            //                }
            //                else
            //                {
            //                    MessageBox.Show("неверный пароль");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if (textbox1.Text == "")
            //            {
            //                MessageBox.Show("где логин");
            //            }
            //            else
            //            {
            //                MessageBox.Show("неверный логин");
            //            }

            //        }
        }


    }


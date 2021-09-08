using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RABotaPZ
{
    public partial class MainForm : Form
    {
        private string connectionString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=RABotaPZ;User Id=sa;Password=ddmkavich22";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("При закрытии консоли закроется приложение!");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlcom2 = "select * from classroom";
                string sqlcom3 = "select * from student";
                SqlDataAdapter adapter1 = new SqlDataAdapter(sqlcom2, connection);
                DataSet ds1 = new DataSet();
                SqlDataAdapter adapter2 = new SqlDataAdapter(sqlcom3, connection);
                DataSet ds2 = new DataSet();
                adapter1.Fill(ds1);
                adapter2.Fill(ds2);
                classroomsDGV.DataSource = ds1.Tables[0];
                studentsDGV.DataSource = ds2.Tables[0];
            }
            selectMethod();
        }
        void selectMethod()
        {
            string sqlcom1 = "select * from class";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открываем подключение
                    connection.Open();
                    //MessageBox.Show("Подключено к " + connection.Database);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcom1, connection);
                    adapter.Fill(ds);
                    classDGV.DataSource = ds.Tables[0];

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitButn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStudentButn_Click(object sender, EventArgs e)
        {
            addStudentForm addStudentForm = new addStudentForm();
            this.Hide();
            addStudentForm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "SELECT * FROM student";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read()) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object lastname = reader.GetValue(2);

                        Console.WriteLine("{0} \t{1} \t{2}", id, name, lastname);
                    }
                }

                reader.Close();
            }

            Console.Read();
        }
    }
}

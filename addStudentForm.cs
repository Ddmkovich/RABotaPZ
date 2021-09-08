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
    public partial class addStudentForm : Form
    {
        private string connectionString = @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=RABotaPZ;User Id=sa;Password=ddmkavich22";
        public addStudentForm()
        {
            InitializeComponent();
        }

        private void addStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string sqlcom = "insert into student (first_name, last_name, date_of_birth, adress, email) values (@first_name, @last_name, @date_of_birth, @adress, @email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlParameter nameParam1 = new SqlParameter("@first_name", first_name.Text);
                    SqlParameter nameParam2 = new SqlParameter("@last_name", last_name.Text);
                    SqlParameter nameParam3 = new SqlParameter("@date_of_birth", date_of_birth.Text);
                    SqlParameter nameParam4 = new SqlParameter("@adress", adress.Text);
                    SqlParameter nameParam5 = new SqlParameter("@email", email.Text);
                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.Add(nameParam1);
                    command.Parameters.Add(nameParam2);
                    command.Parameters.Add(nameParam3);
                    command.Parameters.Add(nameParam4);
                    command.Parameters.Add(nameParam5);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void studentFormExit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblError.Hide();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mphom\source\repos\WindowsFormsApp1\WindowsFormsApp1\PeopleData.mdf;Integrated Security=True");
        SqlCommand comm;
        SqlDataReader reader;
        
        String password;


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            GlobalData.name = txtUsername.Text;
            String username = GlobalData.name;
            password = txtPassword.Text;
            comm = new SqlCommand("SELECT Username, Password FROM CustomersT WHERE Username = @Username AND Password = @Password", conn);

            comm.Parameters.AddWithValue("@Username", username);
            comm.Parameters.AddWithValue("@Password", password);
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    /*lblError.Show();
                    lblError.Text = "Thank you.....";*/
                    ChatPage chatPage = new ChatPage();
                    chatPage.ShowDialog();

                }
                else
                {
                    lblError.Show();
                    lblError.Text = "Incorrect Username or Password....";

                }
            }


                conn.Close();

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}

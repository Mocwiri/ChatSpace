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
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            label2.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mphom\source\repos\WindowsFormsApp1\WindowsFormsApp1\PeopleData.mdf;Integrated Security=True");
        SqlCommand comm;
        String username;
        String password;
        String surname;
        String numbers;
        int follower = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            conn.Open();
            username = txtName.Text.Trim();
            password = txtPassword.Text.Trim();
            surname = txtSurname.Text.Trim();
            numbers = txtCellNumber.Text.Trim().PadRight(10, ' ');

            comm = new SqlCommand("INSERT INTO CustomersT VALUES (@Username,@Password,@CellNumber,@Surname,@Followers)", conn);

            comm.Parameters.AddWithValue("@Username", username);
            comm.Parameters.AddWithValue("@Password", password);
            comm.Parameters.AddWithValue("@CellNumber", numbers);
            comm.Parameters.AddWithValue("@Surname", surname);
            comm.Parameters.AddWithValue("@Followers", follower);

            int rowsAffected = comm.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                label2.Show();
                label2.Text = ("Insert successful.");
            }
            else
            {
                label2.Show();
                label2.Text = ("Insert failed.");
            }
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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

namespace WindowsFormsApp1
{
    public partial class FollowerNdLikePg : Form
    {
        public FollowerNdLikePg()
        {
            InitializeComponent();
            cbFollowers.Items.Clear();
            cbLikes.Items.Clear();
            LoadUsersIntoComboBoxFollowers();
            LoadUsersIntoComboBoxLikes();
            label1.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mphom\source\repos\WindowsFormsApp1\WindowsFormsApp1\PeopleData.mdf;Integrated Security=True");
        SqlCommand comm;
        SqlDataReader reader;

        private void LoadUsersIntoComboBoxFollowers()
        {
            conn.Open();
            comm = new SqlCommand("SELECT DISTINCT Username FROM CustomersT", conn);

            using (SqlDataReader reader = comm.ExecuteReader())
            {
                cbFollowers.Items.Clear(); // Clear existing items

                while (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    cbFollowers.Items.Add(username); // Add each username to the ComboBox
                }
            }

            conn.Close();
        }

        private void LoadUsersIntoComboBoxLikes()
        {
            conn.Open();
            comm = new SqlCommand("SELECT DISTINCT Message FROM MessageT", conn);

            using (SqlDataReader reader = comm.ExecuteReader())
            {
                cbLikes.Items.Clear(); // Clear existing items

                while (reader.Read())
                {
                    string username = reader["Message"].ToString();
                    cbLikes.Items.Add(username); // Add each username to the ComboBox
                }
            }

            conn.Close();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            label1.Show();
            conn.Open();
            string selectedFollower = cbFollowers.SelectedItem?.ToString();
            string selectedMessage = cbLikes.SelectedItem?.ToString();

            /*if (string.IsNullOrEmpty(selectedFollower) || string.IsNullOrEmpty(selectedMessage))
            {
                label1.Text = "Please select a follower Or a message to like.";
            }*/
                
            comm = new SqlCommand("UPDATE CustomersT SET Followers = Followers + 1 WHERE Username = @Username", conn);
            comm.Parameters.AddWithValue("@Username", selectedFollower);
            int followerRow = comm.ExecuteNonQuery();

                // Increment the like count for the selected message
            comm = new SqlCommand("UPDATE MessageT SET Likes = Likes + 1 WHERE Message = @Message", conn);
            comm.Parameters.AddWithValue("@Message", selectedMessage);
            int messageRow = comm.ExecuteNonQuery();

            if (followerRow == 0)
            {
                label1.Text = "Failed to update follower count. User may not exist.";
            }
            else if (messageRow == 0)
            {
                label1.Text = "Failed to update like count. Message may not exist.";
            }
            else
            {
                label1.Text = "Follower and like counts updated successfully!";
            }

            conn.Close();
        }
    }
}

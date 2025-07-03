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
using System.Linq.Expressions;

namespace WindowsFormsApp1
{
    public partial class ChatPage : Form
    {
        public ChatPage()
        {
            InitializeComponent();
            label2.Hide();
            ChatBox.Items.Clear();
            LoadDataIntoChatBox();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mphom\source\repos\WindowsFormsApp1\WindowsFormsApp1\PeopleData.mdf;Integrated Security=True");
        SqlCommand comm;
        SqlDataReader reader;

        private void LoadDataIntoChatBox()
        {
            conn.Open();

            comm = new SqlCommand("SELECT * FROM MessageT", conn);

            using (reader = comm.ExecuteReader())
            {
                // Clear the ListBox before loading new data
                ChatBox.Items.Clear();

                // Create column headers with fixed-width spacing
                string header = String.Format("{0,-15} {1,-20} {2,-40}", "Username", "Topic", "Message");
                ChatBox.Items.Add(header);
                ChatBox.Items.Add(new string('-', 75)); // separator line

                // Read and format each row
                while (reader.Read())
                {
                    string item = String.Format("{0,-15} {1,-20} {2,-40}",
                        reader["Username"].ToString(),
                        reader["Topic"].ToString(),
                        reader["Message"].ToString());

                    ChatBox.Items.Add(item);
                }
            }

            conn.Close();
        }



        private void btnChat_Click(object sender, EventArgs e)
        {
            conn.Open();
            String username = GlobalData.name;
            String topic = txtTopic.Text;
            String message = txtMessage.Text;
            int like = 0;

            ChatBox.Items.Clear();

            comm = new SqlCommand("INSERT INTO MessageT (Username,Message,Topic,Likes) VALUES (@Username, @Message, @Topic,@Likes)", conn);

            comm.Parameters.AddWithValue("@Username", username);
            comm.Parameters.AddWithValue("@Topic", topic);
            comm.Parameters.AddWithValue("@Message", message);
            comm.Parameters.AddWithValue("@Likes", like);

            comm.ExecuteNonQuery();

            label2.Show();
            conn.Close();
            label2.Text = "Your Opinion was Captured Successfully.....";
            
            LoadDataIntoChatBox();

        }

        private void BtnLF_Click(object sender, EventArgs e)
        {
            FollowerNdLikePg FollowersLikes = new FollowerNdLikePg();
            FollowersLikes.ShowDialog();
        }
    }
}

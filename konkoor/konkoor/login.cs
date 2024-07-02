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
using konkoor.Properties;


namespace konkoor
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbproject;Integrated Security=True");
        private void loginbut_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (usernames.Text != "" && passwords.Text != "")
            {
                string query = "select count(*) from users where usernames='" + usernames.Text + "' and " +
                    "passwords = '" + passwords.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("this username or password does not exist");
                }
                else
                {
                    this.Hide();
                    safheasli safheasli = new safheasli();
                    safheasli.Show();
                    usernames.Text = "";
                    passwords.Text = "";
                }

            }
            else
            {
                MessageBox.Show("fill in the blank");
            }
        }
    }
}

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

namespace konkoor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbproject;Integrated Security=True");
        private void username_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (usernamestext.Text != "" && passwords.Text != "" && conpass.Text != "" && email.Text != "")
                {
                    if (passwords.Text == conpass.Text)
                    {
                        int v = check(usernamestext.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into users values(@usernames , @passwords , @email)", connection);
                            command.Parameters.AddWithValue("@usernames", usernamestext.Text);
                            command.Parameters.AddWithValue("@passwords", passwords.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("sign in successfully");
                            usernamestext.Text = "";
                            passwords.Text = "";
                            conpass.Text = "";
                            email.Text = "";

                        }

                        else
                        {
                            MessageBox.Show("there is an existing account with this username");
                        }
                    }

                    else
                    {
                        MessageBox.Show("password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("fill in the blank");
                }

            

        }
        int check(String usernames)
        {
                connection.Open();
                string query = "select count(*) from users where usernames='" + usernames + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                connection.Close();
                return v;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void usernames_TextChanged(object sender, EventArgs e)
        {

        }
    }

}   

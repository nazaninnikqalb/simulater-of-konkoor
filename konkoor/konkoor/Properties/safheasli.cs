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


namespace konkoor.Properties
{
    public partial class safheasli : Form
    {
        public safheasli()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dbproject;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if(nam.Text!="" && namkhanevadegi.Text!="" && nampedar.Text!="" && codemeli.Text!="" && shomareshenasname.Text!=""
                    && codeshenasname.Text!="" && jensiat.Text!="" && date.Text!="" && codekarshenasi.Text!="" && codeemtehani.Text!=""
                    && tellhamrah.Text!="" && tellsabet.Text!="" && codeposti.Text!="" && email.Text != "")
                {
                    
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into konkoor values(@nam , @namkhanevadegi , @nampedar , @codemeli," +
                        "@shomareshenasname , @codeshenasname , @jensiat , @tarikhtavalod , @codekarshenasi , @codeemtehani, @codeposti , @tellhamrah," +
                        "@tellsabet  , @email)", connection);
                    command.Parameters.AddWithValue("@nam", nam.Text);
                    command.Parameters.AddWithValue("@namkhanevadegi", namkhanevadegi.Text);
                    command.Parameters.AddWithValue("@nampedar", nampedar.Text);
                    command.Parameters.AddWithValue("@codemeli", codemeli.Text);
                    command.Parameters.AddWithValue("@shomareshenasname", shomareshenasname.Text);
                    command.Parameters.AddWithValue("@codeshenasname", codeshenasname.Text);
                    command.Parameters.AddWithValue("@jensiat", jensiat.Text);
                    command.Parameters.AddWithValue("tarikhtavalod", Convert.ToDateTime(date.Text));
                    command.Parameters.AddWithValue("@codekarshenasi", codekarshenasi.Text);
                    command.Parameters.AddWithValue("@codeemtehani", codeemtehani.Text);
                    command.Parameters.AddWithValue("@codeposti", codeposti.Text);
                    command.Parameters.AddWithValue("@tellhamrah", tellhamrah.Text);
                    command.Parameters.AddWithValue("@tellsabet", tellsabet.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("sabtenam ba movafaghiyat anjam shod");
                    nam.Text = "";
                    namkhanevadegi.Text = "";
                    nampedar.Text = "";
                    jensiat.Text = "";
                    codemeli.Text = "";
                    shomareshenasname.Text = "";
                    codeshenasname.Text = "";
                    codekarshenasi.Text = "";
                    codeemtehani.Text = "";
                    tellhamrah.Text = "";
                    tellsabet.Text = "";
                    codeposti.Text = "";
                    email.Text = "";


                }
                else
                {
                    MessageBox.Show("fill in the blank");
                }
               
        }

        private void buttonsabt_Click(object sender, EventArgs e)
        {
            if (nam.Text != "" && namkhanevadegi.Text != "" && nampedar.Text != "" && codemeli.Text != "" && shomareshenasname.Text != ""
                    && codeshenasname.Text != "" && jensiat.Text != "" && date.Text != "" && codekarshenasi.Text != "" && codeemtehani.Text != ""
                    && tellhamrah.Text != "" && tellsabet.Text != "" && codeposti.Text != "" && email.Text != "")
            {

                connection.Open();
                SqlCommand command = new SqlCommand("insert into konkoor values(@nam , @namkhanevadegi , @nampedar , @codemeli," +
                    "@shomareshenasname , @codeshenasname , @jensiat , @tarikhtavalod , @codekarshenasi , @codeemtehani, @codeposti , @tellhamrah," +
                    "@tellsabet  , @email)", connection);
                command.Parameters.AddWithValue("@nam", nam.Text);
                command.Parameters.AddWithValue("@namkhanevadegi", namkhanevadegi.Text);
                command.Parameters.AddWithValue("@nampedar", nampedar.Text);
                command.Parameters.AddWithValue("@codemeli", codemeli.Text);
                command.Parameters.AddWithValue("@shomareshenasname", shomareshenasname.Text);
                command.Parameters.AddWithValue("@codeshenasname", codeshenasname.Text);
                command.Parameters.AddWithValue("@jensiat", jensiat.Text);
                command.Parameters.AddWithValue("tarikhtavalod", Convert.ToDateTime(date.Text));
                command.Parameters.AddWithValue("@codekarshenasi", codekarshenasi.Text);
                command.Parameters.AddWithValue("@codeemtehani", codeemtehani.Text);
                command.Parameters.AddWithValue("@codeposti", codeposti.Text);
                command.Parameters.AddWithValue("@tellhamrah", tellhamrah.Text);
                command.Parameters.AddWithValue("@tellsabet", tellsabet.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("sabtenam ba movafaghiyat anjam shod");
                nam.Text = "";
                namkhanevadegi.Text = "";
                nampedar.Text = "";
                jensiat.Text = "";
                codemeli.Text = "";
                shomareshenasname.Text = "";
                codeshenasname.Text = "";
                codekarshenasi.Text = "";
                codeemtehani.Text = "";
                tellhamrah.Text = "";
                tellsabet.Text = "";
                codeposti.Text = "";
                email.Text = "";


            }
            else
            {
                MessageBox.Show("fill in the blank");
            }

        }
    }
}

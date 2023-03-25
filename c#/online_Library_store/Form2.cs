using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_Library_store
{
    public partial class Form2 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT title,price FROM Document_", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("insert into BOOKS_BOUGHT values(@Btitle,@Rname)", sqlcon);
                cmd.Parameters.AddWithValue("@Btitle", textBox2.Text);
                cmd.Parameters.AddWithValue("@Rname", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("you bought this book successfully");
                sqlcon.Close();
            }
           
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Document_ values(@Bid,@title,@price,@author_name,@sold_copies,@year,@month)", con);
            cmd.Parameters.AddWithValue("@Bid", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@title", textBox2.Text);
            cmd.Parameters.AddWithValue("@price", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@author_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@sold_copies", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@year", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@month", textBox7.Text);
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("you uploaded a book successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }
    }
}

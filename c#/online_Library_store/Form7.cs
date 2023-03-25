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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into category values(@Cname,@Btitle,@Bnum)", con);
            cmd.Parameters.AddWithValue("@Cname", textBox1.Text);
            cmd.Parameters.AddWithValue("@Btitle", textBox2.Text);
            cmd.Parameters.AddWithValue("@Bnum", int.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("you categorized books successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

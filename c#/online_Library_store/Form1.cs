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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into user_account values(@gender,@Name,@email,@phone)",con);
            cmd.Parameters.AddWithValue("@gender",textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("you signed up successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into reader_ values(@gender,@Rname,@Remail,@Rphone,@books_bought)", con);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@Rname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Remail", textBox3.Text);
            cmd.Parameters.AddWithValue("@Rphone", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@books_bought", int.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
            con.Close();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Admin_ values(@gender,@Aname,@Aemail,@Aphone)", con);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@Aname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Aemail", textBox3.Text);
            cmd.Parameters.AddWithValue("@Aphone", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
            con.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into AUTHOR_ values(@gender,@AUname,@AUemail,@AUphone,@Bid)", con);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@AUname", textBox2.Text);
            cmd.Parameters.AddWithValue("@AUemail", textBox3.Text);
            cmd.Parameters.AddWithValue("@AUphone", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Bid", int.Parse(textBox6.Text));
            cmd.ExecuteNonQuery();
        
            con.Close();
            MessageBox.Show("you signed up as a author successfully");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update user_account set gender=@gender ,Name=@Name,phone=@phone where email=@email", con);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", int.Parse(textBox4.Text));
            
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("updated");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update reader_ set gender=@gender ,Rname=@Rname,Rphone=@Rphone , books_bought=@books_bought where Remail=@Remail", con);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@Rname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Remail", textBox3.Text);
            cmd.Parameters.AddWithValue("@Rphone", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@books_bought", int.Parse(textBox5.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("updated");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Admin_ set gender=@gender ,Aname=@Aname,Aphone=@Aphone where Aemail=@Aemail", con);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@Aname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Aemail", textBox3.Text);
            cmd.Parameters.AddWithValue("@Aphone", int.Parse(textBox4.Text));
            

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("updated");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update AUTHOR_ set gender=@gender ,AUname=@AUname,AUphone=@AUphone,Bid=@Bid where AUemail=@AUemail", con);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@AUname", textBox2.Text);
            cmd.Parameters.AddWithValue("@AUemail", textBox3.Text);
            cmd.Parameters.AddWithValue("@AUphone", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Bid", int.Parse(textBox6.Text));


            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("updated");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
            this.Close();
        }
    }
}

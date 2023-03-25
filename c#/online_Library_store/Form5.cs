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
    public partial class Form5 : Form
    {
        string connectionstring = @"Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT title,author_name,year,month FROM Document_", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}

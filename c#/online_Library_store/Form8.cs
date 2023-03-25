using Microsoft.Reporting.WinForms;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O6J1GII;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Bid,title,sold_copies,price from Document_", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable td = new DataTable();
            da.Fill(td);
            ReportDataSource rds = new ReportDataSource("DataSet1",td);
            
            reportViewer1.LocalReport.ReportPath = @"C:\Users\HP\Desktop\online_Library_store\online_Library_store\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

           
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

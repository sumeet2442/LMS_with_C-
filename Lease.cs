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

namespace Libraray_Management_System
{
    public partial class Lease : Form
    {
        public static string leBook="";
        SqlConnection conLease = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sumeet Gupta\documents\visual studio 2015\Projects\Libraray_Management_System\Libraray_Management_System\Library_Data.mdf;Integrated Security=True");
        public Lease()
        {

            InitializeComponent();
        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void Lease_Load(object sender, EventArgs e)
        {
            conLease.Open();
            SqlCommand cmd = conLease.CreateCommand();
            cmd.CommandText = "select * from BookDetail";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conLease.Close();
        }

        private void bt_PersonDetail_Click(object sender, EventArgs e)
        {
            leBook = txtbox_BookId.Text;
            this.Hide();
            CustomerDetails view = new CustomerDetails();
            view.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 view = new Form1();
            view.Show();
        }
    }
}

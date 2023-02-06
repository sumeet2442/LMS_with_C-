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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sumeet Gupta\documents\visual studio 2015\Projects\Libraray_Management_System\Libraray_Management_System\Library_Data.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Donate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donate view = new Donate();
            view.Show();
        }

        private void bt_Lease_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lease view = new Lease();
            view.Show();
        }

        private void bt_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return view = new Return();
            view.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback view = new Feedback();
            view.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
        }
    }
}

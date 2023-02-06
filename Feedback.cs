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
    public partial class Feedback : Form
    {
        SqlConnection conFeed = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sumeet Gupta\documents\visual studio 2015\Projects\Libraray_Management_System\Libraray_Management_System\Library_Data.mdf;Integrated Security=True");
        public Feedback()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            conFeed.Open();
            SqlCommand cmd = conFeed.CreateCommand();
            cmd.CommandText = "insert into Feedback values('" + txtbox_Name.Text + "','" + txtbox_Phone.Text + "','" + txtbox_Feedback.Text+ "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thank you for your Feedback! :)");
            conFeed.Close();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 view = new Form1();
            view.Show();
        }
    }
}

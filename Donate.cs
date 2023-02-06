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
    public partial class Donate : Form
    {
        
        SqlConnection conDonate = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sumeet Gupta\documents\visual studio 2015\Projects\Libraray_Management_System\Libraray_Management_System\Library_Data.mdf;Integrated Security=True");
        public Donate()
        {
            InitializeComponent();
        }

        private void bt_Donate_Click(object sender, EventArgs e)
        {       
            conDonate.Open();
            SqlCommand cmd = conDonate.CreateCommand();
            cmd.CommandText = "insert into BookDetail(bookName,bookAuthor,bookPublisher,bookPage) values('"+txtbox_BookName.Text+"','"+txtbox_BookAuthor.Text+"','"+txtbox_BookPublisher.Text+"','"+txtbox_BookPage.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book succefully donated,Thank You :)");
            conDonate.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 view = new Form1();
            view.Show();
        }
    }
}

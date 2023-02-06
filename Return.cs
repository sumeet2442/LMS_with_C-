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
    public partial class Return : Form
    {
        
        SqlConnection conReturn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sumeet Gupta\documents\visual studio 2015\Projects\Libraray_Management_System\Libraray_Management_System\Library_Data.mdf;Integrated Security=True");
        public Return()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 view = new Form1();
            view.Show();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            conReturn.Open();
            SqlCommand cmd = conReturn.CreateCommand();
            cmd.CommandText = "select * from BookOnLease";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conReturn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txtbox_BookId.Text = row.Cells[1].Value.ToString();
                txtbox_CustomerName.Text = row.Cells[2].Value.ToString();
                txtbox_BookDate.Text = row.Cells[3].Value.ToString();
                txtbox_ReturnDate.Text = row.Cells[4].Value.ToString();
            }
        }
        private void bt_Return_Click(object sender, EventArgs e)
        { 
            conReturn.Open();
            SqlCommand cmd = conReturn.CreateCommand();
            cmd.CommandText = "SET IDENTITY_INSERT BookDetail ON; insert into BookDetail(bookId,bookName,bookAuthor,bookPublisher,bookPage) select bookId,bookName,bookAuthor,bookPublisher,bookPage from BookDetailCopy where bookId = " + txtbox_BookId.Text+"SET IDENTITY_INSERT BookDetail OFF;";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from BookDetailCopy where bookId="+txtbox_BookId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from CustomerDetail where bookId="+txtbox_BookId.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from BookOnLease where bookId=" + txtbox_BookId.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thanks for returning the book, hope you had a good time reading it.");
            dataGridView2.Update();
            dataGridView2.Refresh();
            conReturn.Close();
        }

    }
}

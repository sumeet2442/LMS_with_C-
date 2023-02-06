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
    public partial class CustomerDetails : Form
    {
        SqlConnection conCustomerDetail= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sumeet Gupta\documents\visual studio 2015\Projects\Libraray_Management_System\Libraray_Management_System\Library_Data.mdf;Integrated Security=True");
        public static string bookId = Lease.leBook;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void lbl_BookDetail_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
             lbl_Change.Text= "You are going to take away a book with bookId = "+bookId+" ,To continue enter your details below:-";        
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            conCustomerDetail.Open();
            SqlCommand cmd = conCustomerDetail.CreateCommand();
            cmd.CommandText = "insert into CustomerDetail(bookId,customerName,customerMobileNo,Booking_Date,Return_Date) values('"+bookId+"','" + txtbox_Name.Text + "','" + txtbox_MobileNo.Text + "','" + txtbox_BookingDate.Text + "','" + txtbox_ReturnDate.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into BookOnLease(bookId,customerName,Booking_Date,Return_Date) values ('"+bookId+"','"+txtbox_Name.Text+"','"+txtbox_BookingDate.Text+"','"+txtbox_ReturnDate.Text+"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into BookDetailCopy select * from BookDetail where bookId="+bookId;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from BookDetail where BookId = "+bookId+" ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("You can take the book now, Thank you for using Shelfish Library! :)");
            conCustomerDetail.Close();
        }

        private void lbl_Change_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 view = new Form1();
            view.Show();
        }
    }
}

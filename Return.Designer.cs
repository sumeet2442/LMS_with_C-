namespace Libraray_Management_System
{
    partial class Return
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Return_Title = new System.Windows.Forms.Label();
            this.bt_Return = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Home = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookOnLeaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DataDataSet1 = new Libraray_Management_System.Library_DataDataSet1();
            this.bookOnLeaseTableAdapter = new Libraray_Management_System.Library_DataDataSet1TableAdapters.BookOnLeaseTableAdapter();
            this.lbl_BookId = new System.Windows.Forms.Label();
            this.lbl_BookDate = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.lbl_ReturnDate = new System.Windows.Forms.Label();
            this.txtbox_BookId = new System.Windows.Forms.TextBox();
            this.txtbox_CustomerName = new System.Windows.Forms.TextBox();
            this.txtbox_ReturnDate = new System.Windows.Forms.TextBox();
            this.txtbox_BookDate = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOnLeaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Return_Title
            // 
            this.lbl_Return_Title.AutoSize = true;
            this.lbl_Return_Title.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Return_Title.Location = new System.Drawing.Point(351, 18);
            this.lbl_Return_Title.Name = "lbl_Return_Title";
            this.lbl_Return_Title.Size = new System.Drawing.Size(329, 57);
            this.lbl_Return_Title.TabIndex = 0;
            this.lbl_Return_Title.Text = "Return The Book";
            // 
            // bt_Return
            // 
            this.bt_Return.BackColor = System.Drawing.Color.PaleVioletRed;
            this.bt_Return.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Return.Location = new System.Drawing.Point(479, 582);
            this.bt_Return.Name = "bt_Return";
            this.bt_Return.Size = new System.Drawing.Size(151, 39);
            this.bt_Return.TabIndex = 3;
            this.bt_Return.Text = "Return";
            this.bt_Return.UseVisualStyleBackColor = false;
            this.bt_Return.Click += new System.EventHandler(this.bt_Return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Libraray_Management_System.Properties.Resources.returncopy;
            this.pictureBox1.Location = new System.Drawing.Point(275, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 63);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_Home
            // 
            this.bt_Home.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_Home.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Home.Location = new System.Drawing.Point(286, 582);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.Size = new System.Drawing.Size(151, 39);
            this.bt_Home.TabIndex = 5;
            this.bt_Home.Text = "Home";
            this.bt_Home.UseVisualStyleBackColor = false;
            this.bt_Home.Click += new System.EventHandler(this.bt_Home_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bookOnLeaseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(134, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(677, 272);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "Serial_No";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial_No";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookOnLeaseBindingSource
            // 
            this.bookOnLeaseBindingSource.DataMember = "BookOnLease";
            this.bookOnLeaseBindingSource.DataSource = this.library_DataDataSet1;
            // 
            // library_DataDataSet1
            // 
            this.library_DataDataSet1.DataSetName = "Library_DataDataSet1";
            this.library_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookOnLeaseTableAdapter
            // 
            this.bookOnLeaseTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_BookId
            // 
            this.lbl_BookId.AutoSize = true;
            this.lbl_BookId.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookId.Location = new System.Drawing.Point(130, 446);
            this.lbl_BookId.Name = "lbl_BookId";
            this.lbl_BookId.Size = new System.Drawing.Size(87, 24);
            this.lbl_BookId.TabIndex = 7;
            this.lbl_BookId.Text = "BookId:-";
            this.lbl_BookId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_BookDate
            // 
            this.lbl_BookDate.AutoSize = true;
            this.lbl_BookDate.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookDate.Location = new System.Drawing.Point(130, 508);
            this.lbl_BookDate.Name = "lbl_BookDate";
            this.lbl_BookDate.Size = new System.Drawing.Size(141, 24);
            this.lbl_BookDate.TabIndex = 7;
            this.lbl_BookDate.Text = "Booking Date:-";
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(475, 447);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(160, 24);
            this.lbl_CustomerName.TabIndex = 7;
            this.lbl_CustomerName.Text = "Customer Name:-";
            this.lbl_CustomerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ReturnDate
            // 
            this.lbl_ReturnDate.AutoSize = true;
            this.lbl_ReturnDate.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnDate.Location = new System.Drawing.Point(475, 508);
            this.lbl_ReturnDate.Name = "lbl_ReturnDate";
            this.lbl_ReturnDate.Size = new System.Drawing.Size(135, 24);
            this.lbl_ReturnDate.TabIndex = 7;
            this.lbl_ReturnDate.Text = "Return Date:-";
            this.lbl_ReturnDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox_BookId
            // 
            this.txtbox_BookId.Location = new System.Drawing.Point(286, 450);
            this.txtbox_BookId.Name = "txtbox_BookId";
            this.txtbox_BookId.Size = new System.Drawing.Size(151, 20);
            this.txtbox_BookId.TabIndex = 8;
            // 
            // txtbox_CustomerName
            // 
            this.txtbox_CustomerName.Location = new System.Drawing.Point(660, 449);
            this.txtbox_CustomerName.Name = "txtbox_CustomerName";
            this.txtbox_CustomerName.Size = new System.Drawing.Size(151, 20);
            this.txtbox_CustomerName.TabIndex = 8;
            // 
            // txtbox_ReturnDate
            // 
            this.txtbox_ReturnDate.Location = new System.Drawing.Point(660, 511);
            this.txtbox_ReturnDate.Name = "txtbox_ReturnDate";
            this.txtbox_ReturnDate.Size = new System.Drawing.Size(151, 20);
            this.txtbox_ReturnDate.TabIndex = 8;
            // 
            // txtbox_BookDate
            // 
            this.txtbox_BookDate.Location = new System.Drawing.Point(286, 512);
            this.txtbox_BookDate.Name = "txtbox_BookDate";
            this.txtbox_BookDate.Size = new System.Drawing.Size(151, 20);
            this.txtbox_BookDate.TabIndex = 8;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(45, 103);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(874, 24);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "Select the row that matches your name and bookId of the book you leased.";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(964, 633);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtbox_BookDate);
            this.Controls.Add(this.txtbox_ReturnDate);
            this.Controls.Add(this.txtbox_CustomerName);
            this.Controls.Add(this.txtbox_BookId);
            this.Controls.Add(this.lbl_BookDate);
            this.Controls.Add(this.lbl_ReturnDate);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_BookId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bt_Home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Return);
            this.Controls.Add(this.lbl_Return_Title);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOnLeaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DataDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Return_Title;
        private System.Windows.Forms.Button bt_Return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Home;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Library_DataDataSet1 library_DataDataSet1;
        private System.Windows.Forms.BindingSource bookOnLeaseBindingSource;
        private Library_DataDataSet1TableAdapters.BookOnLeaseTableAdapter bookOnLeaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_BookId;
        private System.Windows.Forms.Label lbl_BookDate;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.Label lbl_ReturnDate;
        private System.Windows.Forms.TextBox txtbox_BookId;
        private System.Windows.Forms.TextBox txtbox_CustomerName;
        private System.Windows.Forms.TextBox txtbox_ReturnDate;
        private System.Windows.Forms.TextBox txtbox_BookDate;
        private System.Windows.Forms.Label lbl_Title;
    }
}
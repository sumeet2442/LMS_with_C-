namespace Libraray_Management_System
{
    partial class Lease
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DataDataSet = new Libraray_Management_System.Library_DataDataSet();
            this.bookDetailTableAdapter = new Libraray_Management_System.Library_DataDataSetTableAdapters.BookDetailTableAdapter();
            this.txtbox_BookId = new System.Windows.Forms.TextBox();
            this.bt_PersonDetail = new System.Windows.Forms.Button();
            this.lbl_BookIdText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(373, 22);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(300, 61);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Lease a Book";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the book id and select continue button\r\nto enter your details.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookPublisherDataGridViewTextBoxColumn,
            this.bookPageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookDetailBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.Location = new System.Drawing.Point(143, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(627, 347);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "bookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookAuthorDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookPublisherDataGridViewTextBoxColumn
            // 
            this.bookPublisherDataGridViewTextBoxColumn.DataPropertyName = "bookPublisher";
            this.bookPublisherDataGridViewTextBoxColumn.HeaderText = "bookPublisher";
            this.bookPublisherDataGridViewTextBoxColumn.Name = "bookPublisherDataGridViewTextBoxColumn";
            this.bookPublisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookPublisherDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookPageDataGridViewTextBoxColumn
            // 
            this.bookPageDataGridViewTextBoxColumn.DataPropertyName = "bookPage";
            this.bookPageDataGridViewTextBoxColumn.HeaderText = "bookPage";
            this.bookPageDataGridViewTextBoxColumn.Name = "bookPageDataGridViewTextBoxColumn";
            this.bookPageDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookPageDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookDetailBindingSource
            // 
            this.bookDetailBindingSource.DataMember = "BookDetail";
            this.bookDetailBindingSource.DataSource = this.library_DataDataSet;
            // 
            // library_DataDataSet
            // 
            this.library_DataDataSet.DataSetName = "Library_DataDataSet";
            this.library_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDetailTableAdapter
            // 
            this.bookDetailTableAdapter.ClearBeforeFill = true;
            // 
            // txtbox_BookId
            // 
            this.txtbox_BookId.Location = new System.Drawing.Point(405, 572);
            this.txtbox_BookId.Multiline = true;
            this.txtbox_BookId.Name = "txtbox_BookId";
            this.txtbox_BookId.Size = new System.Drawing.Size(188, 38);
            this.txtbox_BookId.TabIndex = 4;
            // 
            // bt_PersonDetail
            // 
            this.bt_PersonDetail.BackColor = System.Drawing.Color.PaleVioletRed;
            this.bt_PersonDetail.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PersonDetail.Location = new System.Drawing.Point(609, 572);
            this.bt_PersonDetail.Name = "bt_PersonDetail";
            this.bt_PersonDetail.Size = new System.Drawing.Size(126, 40);
            this.bt_PersonDetail.TabIndex = 5;
            this.bt_PersonDetail.Text = "Continue";
            this.bt_PersonDetail.UseVisualStyleBackColor = false;
            this.bt_PersonDetail.Click += new System.EventHandler(this.bt_PersonDetail_Click);
            // 
            // lbl_BookIdText
            // 
            this.lbl_BookIdText.AutoSize = true;
            this.lbl_BookIdText.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookIdText.Location = new System.Drawing.Point(139, 581);
            this.lbl_BookIdText.Name = "lbl_BookIdText";
            this.lbl_BookIdText.Size = new System.Drawing.Size(260, 22);
            this.lbl_BookIdText.TabIndex = 6;
            this.lbl_BookIdText.Text = "Enter the book id here :-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Libraray_Management_System.Properties.Resources.Leasecrop1;
            this.pictureBox1.Location = new System.Drawing.Point(262, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 61);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(741, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1006, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_BookIdText);
            this.Controls.Add(this.bt_PersonDetail);
            this.Controls.Add(this.txtbox_BookId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Lease";
            this.Load += new System.EventHandler(this.Lease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Library_DataDataSet library_DataDataSet;
        private System.Windows.Forms.BindingSource bookDetailBindingSource;
        private Library_DataDataSetTableAdapters.BookDetailTableAdapter bookDetailTableAdapter;
        private System.Windows.Forms.TextBox txtbox_BookId;
        private System.Windows.Forms.Button bt_PersonDetail;
        private System.Windows.Forms.Label lbl_BookIdText;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}